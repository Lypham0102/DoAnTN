package com.example.myapplication;
import android.content.Intent;
import android.graphics.Color;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import java.time.temporal.ValueRange;

public class MainActivity extends AppCompatActivity {
    public static final String emailPattern ="^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
    private EditText txtEmail;
    private EditText txtPassword;
    private Button btnLogin;
    private TextView txtValidate;
    //Validation
    private Boolean isVaidEmail = false;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        //Map properties in .xml file
        txtEmail =(EditText) findViewById(R.id.txtEmail);
        txtPassword=(EditText) findViewById(R.id.txtPassword);
        txtValidate=(TextView) findViewById(R.id.txtValidate);
        btnLogin = (Button) findViewById(R.id.bntLogin);
        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                //
                //
                if (!isVaidEmail) {
                    Toast.makeText(getApplicationContext(), "Validate email failed ",
                            Toast.LENGTH_LONG).show();
                    return;
                }
                Intent intent = new Intent(MainActivity.this, manhinh.class);
                intent.putExtra("email", txtEmail.getText().toString().trim());
                startActivity(intent);
            }
        });
        //validation
        txtEmail.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {

            }

            @Override
            public void onTextChanged(CharSequence s, int start, int befor, int count) {
            txtValidate.setText("");
            String email = txtEmail.getText().toString().trim();
            isVaidEmail = (email.matches(emailPattern) && s.length() > 0);
            if(!isVaidEmail) {
                txtValidate.setTextColor(Color.rgb( 255,0,0 ));
                txtValidate.setText("Invaid email address");
            }
            }
            @Override
            public void afterTextChanged(Editable s) {

            }
        });

    }
}