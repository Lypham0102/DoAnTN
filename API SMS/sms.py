import firebase_admin
from firebase_admin import credentials
from firebase_admin import db
from twilio.rest import Client

# Cấu hình thông tin tài khoản Twilio
ACCOUNT_SID = 'AC0abe64fe348a8ce67a95cf76f32ddf5f'
AUTH_TOKEN = '8bcd7be9e20a6691d73b2f693f3afc3f'
TWILIO_PHONE_NUMBER = '+18052738662'
RECEIVER_PHONE_NUMBER = '+84386834480'

# Cấu hình thông tin Firebase
cred = credentials.Certificate("/Users/phamcongly/Downloads/esp8266-database-inventor-firebase-adminsdk-8r3df-4691faf0bf.json")
firebase_admin.initialize_app(cred, {
    'databaseURL': 'https://esp8266-database-inventor-default-rtdb.firebaseio.com/'
})

# Lấy đối tượng tham chiếu tới node "TEMPERATURE"
temp_ref = db.reference('TEMPERATURE')

# Định nghĩa hàm callback được gọi khi có thay đổi trên node "TEMPERATURE"
def temperature_changed_callback(event):
    temperature = event.data
    if temperature > 27:
        # Nếu nhiệt độ vượt quá giới hạn, gửi tin nhắn cảnh báo
        client = Client(ACCOUNT_SID, AUTH_TOKEN)
        message = client.messages.create(
            to=RECEIVER_PHONE_NUMBER,
            from_=TWILIO_PHONE_NUMBER,
            body='Nhiệt độ đang vượt quá giới hạn: {}'.format(temperature))
        print('Sent message:', message.sid)

# Đăng ký hàm callback với node "TEMPERATURE"
temp_ref.listen(temperature_changed_callback)
