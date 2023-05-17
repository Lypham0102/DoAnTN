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
temp1_ref = db.reference('TEMPERATURE1')
humidity_ref = db.reference('HUMIDITY')
humidity1_ref = db.reference('HUMIDITY1')
ppm_ref = db.reference('PPM')
ppm1_ref = db.reference('PPM1')

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

# Định nghĩa hàm callback được gọi khi có thay đổi trên node "TEMPERATURE1"
def temperature1_changed_callback(event):
    temperature1 = event.data
    if temperature1 > 27:
        # Nếu nhiệt độ vượt quá giới hạn, gửi tin nhắn cảnh báo
        client = Client(ACCOUNT_SID, AUTH_TOKEN)
        message = client.messages.create(
            to=RECEIVER_PHONE_NUMBER,
            from_=TWILIO_PHONE_NUMBER,
            body='Nhiệt độ đang vượt quá giới hạn: {}'.format(temperature1))
        print('Sent message:', message.sid)

# Định nghĩa hàm callback được gọi khi có thay đổi trên node "HUMIDITY"
def humidity_changed_callback(event):
    humidity = event.data
    if humidity < 60:
        # Nếu độ ẩm vượt quá giới hạn, gửi tin nhắn cảnh báo
        client = Client(ACCOUNT_SID, AUTH_TOKEN)
        message = client.messages.create(
            to=RECEIVER_PHONE_NUMBER,
            from_=TWILIO_PHONE_NUMBER,
            body='Độ ẩm đang thấp hơn mức cho phép: {}'.format(humidity))
        print('Sent message:', message.sid)
# Định nghĩa hàm callback được gọi khi có thay đổi trên node "HUMIDITY1"
def humidity1_changed_callback(event):
    humidity1 = event.data
    if humidity1 < 60:
        # Nếu độ ẩm vượt quá giới hạn, gửi tin nhắn cảnh báo
        client = Client(ACCOUNT_SID, AUTH_TOKEN)
        message = client.messages.create(
            to=RECEIVER_PHONE_NUMBER,
            from_=TWILIO_PHONE_NUMBER,
            body='Độ ẩm đang thấp hơn mức cho phép: {}'.format(humidity1))
        print('Sent message:', message.sid)
# Định nghĩa hàm callback được gọi khi có thay đổi trên node "PPM"
def ppm_changed_callback(event):
    ppm = event.data
    if ppm > 80:
        # Nồng độ gas vượt quá giới hạn, gửi tin nhắn cảnh báo
        client = Client(ACCOUNT_SID, AUTH_TOKEN)
        message = client.messages.create(
            to=RECEIVER_PHONE_NUMBER,
            from_=TWILIO_PHONE_NUMBER,
            body='Nồng độ khi thải cao hơn mức cho phép: {}'.format(ppm))
        print('Sent message:', message.sid)
# Định nghĩa hàm callback được gọi khi có thay đổi trên node "PPM1"
def ppm1_changed_callback(event):
    ppm1 = event.data
    if ppm1 > 80:
        # Nồng độ gas vượt quá giới hạn, gửi tin nhắn cảnh báo
        client = Client(ACCOUNT_SID, AUTH_TOKEN)
        message = client.messages.create(
            to=RECEIVER_PHONE_NUMBER,
            from_=TWILIO_PHONE_NUMBER,
            body='Nồng độ khi thải cao hơn mức cho phép: {}'.format(ppm1))
        print('Sent message:', message.sid)


# Đăng ký hàm callback với node "TEMPERATURE,HUMIDITY,PPM"
temp_ref.listen(temperature_changed_callback)
temp1_ref.listen(temperature1_changed_callback)
humidity_ref.listen(humidity_changed_callback)
humidity1_ref.listen(humidity1_changed_callback)
ppm_ref.listen(ppm_changed_callback)
ppm1_ref.listen(ppm1_changed_callback)
