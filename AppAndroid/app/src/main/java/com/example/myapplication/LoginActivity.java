package com.example.myapplication;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;
import com.example.myapplication.mongodb.MongoDBManager;
import com.mongodb.client.MongoClient;
import com.mongodb.client.MongoCollection;
import com.mongodb.client.MongoDatabase;
import org.bson.Document;
import com.example.myapplication.models.NhanVienModels;


public class LoginActivity extends AppCompatActivity {
    private EditText editTextUserName;
    private EditText editTextPassword;

    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        NhanVienModels nhanVienModels = new NhanVienModels("MaNV", "MaNV", "TenNV",
                "CCCD","SDT", "DiaChi", "MaNT", "TenTaiKhoan",
                "Passwork", "ChucVu", "HeSoLuong", "NganHang", "STK",
                "_idNongTrai", "MaNongTrai");

        editTextUserName = findViewById(R.id.editTextUserName);
        editTextPassword = findViewById(R.id.editTextPassword);
        Button buttonLogin = findViewById(R.id.buttonLogin);
        TextView textViewRegister = findViewById(R.id.textViewRegister);

        buttonLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String tenTaiKhoan = editTextUserName.getText().toString().trim();
                String password = editTextPassword.getText().toString().trim();

                try (MongoClient mongoClient = MongoDBManager.getMongoClient()) {
                    MongoDatabase database = mongoClient.getDatabase("TrangTrai");
                    MongoCollection<Document> nhanVienCollection = database.getCollection("NhanVien");

                    Document query = new Document("TenTaiKhoan", tenTaiKhoan);
                    Document nhanVien = nhanVienCollection.find(query).first();

                    if (nhanVien == null || nhanVien.getString("Passwork") == null) {
                        Toast.makeText(LoginActivity.this, "Tài khoản không tồn tại", Toast.LENGTH_SHORT).show();
                    } else if (!nhanVien.getString("Passwork").equals(password)) {
                        Toast.makeText(LoginActivity.this, "Mật khẩu không chính xác", Toast.LENGTH_SHORT).show();
                    } else {
                        Toast.makeText(LoginActivity.this, "Đăng nhập thành công", Toast.LENGTH_SHORT).show();
                        Intent intent = new Intent(LoginActivity.this, MainActivity.class);
                        startActivity(intent);
                        finish();
                    }
                } catch (Exception e) {
                    // Xử lý exception
                    Log.e("LoginActivity", "Error: " + e.getMessage(), e);
                }
            }
        });
        textViewRegister.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Chuyển sang màn hình đăng ký
            }
        });
    }
}
