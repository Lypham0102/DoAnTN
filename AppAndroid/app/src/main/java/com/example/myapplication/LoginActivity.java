package com.example.myapplication;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;

import com.example.myapplication.mongodb.MongoDBManager;
import com.example.myapplication.models.NhanVienModels;

public class LoginActivity extends AppCompatActivity {
    private EditText editTextUserName;
    private EditText editTextPassword;
    private Button buttonLogin;

    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        editTextUserName = findViewById(R.id.editTextUserName);
        editTextPassword = findViewById(R.id.editTextPassword);
        buttonLogin = findViewById(R.id.buttonLogin);

        buttonLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
               login();
            }
        });
    }

    private void login() {
        String UserName = editTextUserName.getText().toString();
        String Password = editTextPassword.getText().toString();

        if (UserName.isEmpty() || Password.isEmpty()) {
            Toast.makeText(this,"Chưa nhập tên tài khoản hoặc mật khẩu", Toast.LENGTH_LONG).show();
            return;
        }

        MongoDBManager.connect();

        // Xác thực người dùng với Mongodb
        NhanVienModels nhanVien = MongoDBManager.authenticateUser(UserName, Password);

        if ( nhanVien != null) {
            //Đăng nhập thành công
            Intent intent = new Intent(this,MainActivity.class);
            startActivity(intent);
            finish();
        } else {
            //Đăng nhập thất bại
            Toast.makeText(this, "Tài khoản hoặc mật khẩu không hợp lệ",Toast.LENGTH_LONG).show();
        }
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        MongoDBManager.disconnect();
    }


}
