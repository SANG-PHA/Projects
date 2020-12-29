package com.example.coaching;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class start extends AppCompatActivity {


    private Button situp, shoulder, squat, lunge, pushup;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_start);

        situp =(Button)findViewById(R.id.situp);
        situp.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(),MainActivity.class);
                startActivity(intent);

            }
        });

        shoulder =(Button)findViewById(R.id.shoulder);
        shoulder.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(),ShoulderActivity.class);
                startActivity(intent);

            }
        });

        squat =(Button)findViewById(R.id.squat);
        squat.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(),SquatActivity.class);
                startActivity(intent);

            }
        });

        lunge =(Button)findViewById(R.id.Lunge);
        lunge.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(),LungeActivity.class);
                startActivity(intent);

            }
        });

        pushup =(Button)findViewById(R.id.pushup);
        pushup.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(),PushupActivity.class);
                startActivity(intent);

            }
        });
    }
}