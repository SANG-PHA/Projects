package com.example.coaching;

import android.content.Context;
import android.graphics.Color;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.media.MediaPlayer;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.MotionEvent;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import com.github.mikephil.charting.animation.Easing;
import com.github.mikephil.charting.charts.LineChart;
import com.github.mikephil.charting.components.Description;
import com.github.mikephil.charting.components.XAxis;
import com.github.mikephil.charting.components.YAxis;
import com.github.mikephil.charting.data.Entry;
import com.github.mikephil.charting.data.LineData;
import com.github.mikephil.charting.data.LineDataSet;
import com.github.mikephil.charting.interfaces.datasets.ILineDataSet;

import java.util.ArrayList;
import java.util.List;

import static java.lang.Thread.sleep;


public class MainActivity extends AppCompatActivity {

    // 윗몸일으키기 BaseLine
    double[] SitupBaseGyroX = {
            -0.131919,
            0.015407,
            0.08285,
            -0.029121,
            -0.041485,
            -0.10071,
            -0.416089,
            -0.898813,
            -1.211046,
            -1.49507,
            -1.783509,
            -1.721027,
            -1.762703,
            -1.719402,
            -1.474809,
            -1.42987,
            -1.367176,
            -1.362395,
            -1.563055,
            -1.737985,
            -1.33615,
            -0.72393,
            -1.033152,
            -0.456749,
            -0.621614,
            -0.362853,
            -0.077806,
            0.767594,
            1.581824,
            1.910433,
            1.893185,
            2.097225,
            2.311443,
            2.401798,
            2.057207,
            2.009685,
            1.915452,
            1.855854,
            1.476071,
            1.186758,
            -0.187525,
            0.210079,
            -0.030764,
            0.049486,
            -0.084612,
            -0.245721,
            -0.764498,
            -1.273445,
            -1.591105,
            -1.876706,
            -2.102748,
            -2.0439,
            -1.836922,
            -1.738032,
            -1.646247,
            -1.801962,
            -1.756767,
            -1.343409,
            -1.343006,
            -1.101012,
            -0.612811,
            -0.556234,
            -0.481402,
            -0.036413,
            0.081302,
            0.423537,
            1.459735,
            1.966243,
            2.110328,
            2.086825,
            2.116375,
            2.293044,
            2.035309,
            2.005271,
            1.873218,
            1.675615,
            1.351738,
            1.155707,
            0.719501,
            0.072276,
            0.141416,
            0.050708,
            -0.08434,
            -0.248091,
            -0.66371,
            -1.059661,
            -1.482733,
            -1.79347,
            -1.816485,
            -1.802274,
            -1.926572,
            -1.695479,
            -1.845705,
            -1.563933,
            -1.419819,
            -1.747125,
            -1.611925,
            -0.898681,
            -0.889477,
            -0.75349,
            -0.313012,
            -0.303447,
            0.127259,
            0.762548,
            1.750431,
            2.062278,
            2.26642,
            2.405378,
            2.295294,
            2.167854,
            1.807778,
            1.860694,
            1.664197,
            1.482872,
            1.109775,
            0.983532,
            0.319337,
            0.081267,
            0.057888,
            -0.084703,
            -0.206604,
            -0.65893,
            -1.198426,
            -1.50061,
            -1.788463,
            -1.862957,
            -1.884018,
            -1.961735,
            -1.838736,
            -1.618929,
            -1.645097,
            -1.585319,
            -1.793017,
            -1.038601,
            -1.152656,
            -0.585928,
            -0.280686,
            -0.275133,
            -0.020014,
            0.280842,
            0.777481,
            1.703943,
            2.325093,
            2.320061,
            2.377539,
            2.339258,
            2.23975,
            1.984351,
            1.851439,
            1.759308,
            1.305212,
            0.901245,
            0.389279,
            0.145345,
            0.055302,
            -0.094056,
            -0.149913,
            -0.442766,
            -0.947662,
            -1.2796,
            -1.63997,
            -1.975443,
            -1.918625,
            -2.008309,
            -1.847269,
            -1.791481,
            -1.601111,
            -1.603214,
            -1.514779,
            -1.240071,
            -1.132616,
            -0.581015,
            -0.157857,
            -0.197216,
            0.249369,
            1.377,
            1.983033,
            2.259957,
            2.060436,
            2.099856,
            2.469796,
            2.184176,
            1.809648,
            1.622703,
            1.238367,
            1.136344,
            0.736979,
            0.125845,
            0.003896,
            -0.082755,
            -0.409361,
            -0.728417,
            -1.366709,
            -1.903406,
            -2.143387,
            -2.098451,
            -2.154612,
            -2.023196,
            -1.855729,
            -1.757614,
            -1.592978,
            -1.448035,
            -0.633624,
            -0.621001,
            -0.384674,
            -0.049604,
            0.173038,
            0.309237,
            0.930146,
            2.18409,
            2.233394,
            2.499847,
            2.833123,
            2.506859,
            2.047976,
            1.59494,
            1.146052,
            0.850815,
            0.847458,
            0.689953,
            0.125297,
            0.108651,
            -0.081803,
            -0.254189,
            -0.288076,
            -0.483703,
            -1.04348,
            -1.416401,
            -1.716917,
            -1.979418,
            -2.045252,
            -1.941026,
            -1.637354,
            -1.504781,
            -1.415404,
            -1.480484,
            -1.163117,
            -0.969103,
            -0.636137,
            -0.337016,
            0.04292,
            0.156164,
            0.434171,
            1.827317,
            2.749629,
            2.2187,
            1.941743,
            2.016429,
            2.000145,
            1.825097,
            1.629566,
            1.507909,
            1.1686,
            0.815922,
            -0.114545,
            0.200892,
            -0.036072,
            -0.097258,
            -0.188397,
            -0.587848,
            -1.382629,
            -1.743174,
            -1.854865,
            -1.687476,
            -1.614213,
            -1.487988,
            -1.430087,
            -1.434446,
            -1.368848,
            -1.391216,
            -1.415725,
            -0.905866,
            -0.765361,
            -0.525414,
            -0.046998,
            0.202026,
            0.855443,
            1.661332,
            2.287212,
            2.51999,
            2.364172,
            2.422988,
            1.927245,
            1.573253,
            1.177378,
            0.870316,
            0.938683,
            0.458552,
            -0.035719,
            0.04197,
            -0.085164,
            -0.264703,
            -0.708882,
            -1.173782,
            -1.255625,
            -1.459454,
            -1.550227,
            -1.707561,
            -1.809831,
            -1.893946,
            -1.739689,
            -1.482494,
            -1.196297,
            -1.484739,
            -0.972346,
            -0.635865,
            -0.227069,
            0.065252,
            0.3469,
            1.01478,
            1.995299,
            2.562618,
            2.08959,
            2.0662,
            2.05056,
            2.059627,
            1.994602,
            1.504625,
            0.979996,
            0.910207,
            0.205176,
            0.022754,
            -0.037951,
            -0.137128,
            -0.296966,
            -0.690712,
            -0.913614,
            -1.364395,
            -1.578339,
            -1.63974,
            -1.759144,
            -1.770414,
            -1.528103,
            -1.407427,
            -1.49187,
            -1.729875,
            -1.577832,
            -0.935115,
            -0.677139,
            -0.227793,
            -0.051241,
            0.547997,
            1.696173,
            2.447006,
            2.444123,
            2.051534,
            2.042444,
            2.01012,
            1.993573,
            1.415364,
            0.9103,
            0.740952,
            0.751166,
            -0.116557,
            0.004463,
            -0.028134,
            -0.299131,
            -0.890093,
            -1.185079,
            -1.688851,
            -1.712045,
            -1.620223,
            -1.720796,
            -1.745533,
            -1.834822,
            -1.658065,
            -1.835386,
            -1.07256,
            -0.613758,
            -0.2566,
            -0.117377,
            -0.0687,
            -0.08699,
            -0.070728,
            0.028858,
            0.141243,
            0.080232,
            0.003395,
            0.003126,
            0.036087,
            0.015618,
            0.041219,
            0.027336,
            0.027082,
            0.058774,
            0.051362,
            0.006082,
            0.005514,
            0.010226,
            0.010893,
            -0.035577,
            -0.038318,
            0.006429,
            0.030141,
            0.035354,
            0.034773,
            0.038011,
            0.038862,
            0.000796,
            0.0205,
            0.009985,
            -0.00305,
            -0.028617,
            -0.016373,
            -0.020483,
            0.032419,
            0.005857,
            -0.042347,
            0.005275,
            0.037125,
            0.005828,
            -0.032611,
            -0.020878
    };

    private int SitupBaseGyroXPeakIdx_each = 71;
    private int SitupBaseGyroXStartIdx_each = 63;
    private int SitupBaseGyroXEndIdx_each = 102;
    private double SitupBaseGyroXPeakValue_each = 2.484858;
    private int SitupBaseGyroX_Distance = 141 - 132; // 11
    private int[] SitupBaseGyroXPeakIdx = {33,71,107,144,180,212,244,279,311,343}; // 원본과 -62 인덱스차이
    private double[] SitupBaseGyroXPeakValues = {2.401798,2.401798,2.405378,2.377539,2.469796,2.833123,2.749629,2.51999,2.562618,2.447006};


    // ----------------- 여기까지 Baseline Data -----------------

    // 윗몸일으키기 User's data
    double[] SitupUserGyroX = new double[10000];
    private ArrayList<Integer> SitupUserGyroXPeakIdx = new ArrayList<>();
    int PeakIdx = 0;
    double PeakValue = 0;
    int EndIdx = 0;
    double pre_val = 0;
    double acc = 0;

    int idxAccel = 0;
    int idxGyro = 0;
    int start = 0;

    //Using the Accelometer & Gyroscoper
    private SensorManager mSensorManager = null; // 자이로 센서 매니저 객체
    private SensorManager mSensorManager2 = null; // 가속도 센서 매니저 객체

    //Using the Gyroscope
    private SensorEventListener mGyroLis; // 자이로 센서 이벤트 발생 감지 객체
    private Sensor mGgyroSensor = null; // 자이로 센서 변수

    //Using the Accelometer
    private SensorEventListener mAccLis; // 가속도 센서 이벤트 발생 감지 객체
    private Sensor mAccelometerSensor = null; // 가속도 센서 변수

    // 그래프 변수
    private LineChart chart; // 값들을 화면상에서 그래프로 표현해주는 변수
    ArrayList<Entry> values_;
    LineData data;
    ArrayList<ILineDataSet> Sets;
    LineDataSet basedata;

    // 조건문 변수
    boolean working = true;

    // 음성 출력 변수
    MediaPlayer player;

    // 시간 변수
    long start_time;
    long end_time;

    // 카운트 변수
    int big = 0, small = 0, correct = 0, slow = 0, fast = 0, range_good = 0, speed_good = 0;
    int ActionCnt = 0;



    //  ------------ compare insert
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ArrayList<Entry> values = new ArrayList<>(); // x,y좌표 [x, 자이로값]
        for(int i = 0; i < 2 * SitupBaseGyroX.length; i++)
        {
            float val = (float) SitupBaseGyroXPeakValue_each;
            values.add(new Entry(i,val));
        }


        // 베이스 데이터 그래프 그리기
        chart = findViewById(R.id.linechart); // 레이아웃 객체

        basedata = new LineDataSet(values, "Base"); // 데이터셋
        basedata.setDrawCircles(false);
        Sets = new ArrayList<>(); // 데이터셋 어레이리스트
        Sets.add(basedata); // 데이터셋 어레이리스트에 데이터셋 추가
        data = new LineData(Sets);
        basedata.setColor(Color.RED); // 데이터셋 색깔 설정
        chart.setData(data);


        // 유저 데이터 그래프 준비
        values_ = new ArrayList<>(); // x,y좌표 [x, 자이로값]

        //Using the Gyroscope & Accelometer
        mSensorManager = (SensorManager) getSystemService(Context.SENSOR_SERVICE);
        mSensorManager2 = (SensorManager) getSystemService(Context.SENSOR_SERVICE);

        //Using the Accelometer
        mGgyroSensor = mSensorManager.getDefaultSensor(Sensor.TYPE_GYROSCOPE);
        mGyroLis = new MainActivity.GyroscopeListener();

        mAccelometerSensor = mSensorManager2.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);
        mAccLis = new MainActivity.AccelometerListener();

        //Touch Listener for Accelometer
        final Button record = (Button) findViewById(R.id.a_start);

        record.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if(v.getId() == R.id.a_start && working){
                    mSensorManager.registerListener(mGyroLis, mGgyroSensor, SensorManager.SENSOR_DELAY_UI);
                    mSensorManager2.registerListener(mAccLis, mAccelometerSensor, SensorManager.SENSOR_DELAY_UI);
                    working = false;
                    Sets.clear();
                    Sets.add(basedata);
                    data = new LineData(Sets);
                    chart.setData(data);
                    chart.invalidate();
                    PeakIdx = 0;
                    PeakValue = 0;
                    values_.clear();

                    for(int i = 0; i < idxGyro; i++)
                        SitupUserGyroX[i] = 0;
                    idxGyro = 0;
                    big = 0; small = 0; correct = 0; slow = 0; fast = 0; range_good = 0; speed_good = 0; ActionCnt = 0; start = 0; acc= 0;
                    start_time  = System.currentTimeMillis();
                    SetText2();
                    record.setText("기록중지");
                }
                else{
                    mSensorManager.unregisterListener(mGyroLis);
                    mSensorManager2.unregisterListener(mAccLis);
                    working = true;

                    end_time = System.currentTimeMillis();
                    SetText();

                    idxAccel = 0;
                    idxGyro = 0;
                    record.setText("기록시작");
                }
            }
        });
    }

    @Override
    public void onPause(){
        super.onPause();
        Log.e("LOG", "onPause()");
        mSensorManager.unregisterListener(mGyroLis);
    }

    @Override
    public void onDestroy(){
        super.onDestroy();
        Log.e("LOG", "onDestroy()");
        mSensorManager.unregisterListener(mGyroLis);
    }

    // 자이로 센서
    private class GyroscopeListener implements SensorEventListener {

        @Override
        public void onSensorChanged(SensorEvent event) {
            /* 각 축의 각속도 성분을 받는다. */
            double gyroX = event.values[0];
            double gyroY = event.values[1];
            double gyroZ = event.values[2];

            // 리스트에 추가 및 실시간 비교
            SitupUserGyroX[idxGyro] = gyroX;
            compare_each(gyroX, idxGyro);
            idxGyro++;

            // 그래프 그리기
            values_.add(new Entry(idxGyro, (float)gyroX));

            LineDataSet userdata = new LineDataSet(values_, "User"); // 데이터셋
            Sets.clear();
            basedata.setDrawCircles(false);
            userdata.setDrawCircles(false);
            Sets.add(basedata);
            Sets.add(userdata); // 데이터셋 어레이리스트에 데이터셋 추가

            userdata.setColor(Color.BLACK); // 데이터셋 색깔 설정
            data = new LineData(Sets);
            chart.setData(data);
            chart.invalidate();
        }

        @Override
        public void onAccuracyChanged(Sensor sensor, int accuracy) {

        }
    }

    // 가속도 센서
    private class AccelometerListener implements SensorEventListener {
        @Override
        public void onSensorChanged(SensorEvent event) {

        }

        @Override
        public void onAccuracyChanged(Sensor sensor, int accuracy) {

        }
    }

    /// 한 동작 비교 함수
    private void compare_each(double value, int idx)
    {
        boolean EndAct = false;
        // ------------- Process Data -------------
        // 운동이 끝나는 지점 탐색
        if(pre_val > 0.8 && value < 0.8)
        {
            EndIdx = idx;
            EndAct = true;
        }

        // 피크 찾기
        if(value > PeakValue && value > 0.8)
        {
            PeakIdx = idx;
            PeakValue = value;
        }

        pre_val = value;

        if(EndAct) {
            start++;
            // 정확도 계산
            if(PeakValue > SitupBaseGyroXPeakValue_each)
            {
                acc += (SitupBaseGyroXPeakValue_each - (PeakValue - SitupBaseGyroXPeakValue_each)) / SitupBaseGyroXPeakValue_each;
            }
            else
            {
                acc += PeakValue / SitupBaseGyroXPeakValue_each;
            }

            // ------------- Compare -------------
            double difference = 0.05; // 오차
            // 1. 동작 크기 비교
            if (PeakValue > SitupBaseGyroXPeakValue_each * (1 + difference)) // 동작이 크다
            {
                big++;

            } else if (PeakValue < SitupBaseGyroXPeakValue_each * (1 - difference)) // 동작이 작다
            {
                small++;

            } else // 적당한 동작
            {
                range_good++;
            }

            // 2. 동작 속도 비교
            if (EndIdx - PeakIdx > SitupBaseGyroX_Distance + 2) // 동작이 느리다
            {
                slow++;

            } else if (EndIdx - PeakIdx < SitupBaseGyroX_Distance - 2) // 동작이 빠르다
            {
                fast++;

            } else // 적당한 동작
            {
                speed_good++;
            }

            if(start > 0)
            {
                if(start == 1)
                    player = MediaPlayer.create(this, R.raw.one);
                else if(start == 2)
                    player = MediaPlayer.create(this, R.raw.two);
                else if(start == 3)
                    player = MediaPlayer.create(this, R.raw.three);
                else if(start == 4)
                    player = MediaPlayer.create(this, R.raw.four);
                else if(start == 5)
                    player = MediaPlayer.create(this, R.raw.five);
                else if(start == 6)
                    player = MediaPlayer.create(this, R.raw.six);
                else if(start == 7)
                    player = MediaPlayer.create(this, R.raw.seven);
                else if(start == 8)
                    player = MediaPlayer.create(this, R.raw.eight);
                else if(start == 9)
                    player = MediaPlayer.create(this, R.raw.nine);
                else if(start == 10)
                    player = MediaPlayer.create(this, R.raw.ten);
                else if(start == 11)
                    player = MediaPlayer.create(this, R.raw.eleven);
                else if(start == 12)
                    player = MediaPlayer.create(this, R.raw.twelve);
                else if(start == 13)
                    player = MediaPlayer.create(this, R.raw.thirteen);
                else if(start == 14)
                    player = MediaPlayer.create(this, R.raw.fourteen);
                else if(start == 15)
                    player = MediaPlayer.create(this, R.raw.fifteen);
                else if(start == 16)
                    player = MediaPlayer.create(this, R.raw.sixteen);
                else if(start == 17)
                    player = MediaPlayer.create(this, R.raw.seventeen);
                else if(start == 18)
                    player = MediaPlayer.create(this, R.raw.eighteen);
                else if(start == 19)
                    player = MediaPlayer.create(this, R.raw.nineteen);
                else
                    player = MediaPlayer.create(this, R.raw.twenty);

                player.start();
                player.setOnCompletionListener(new MediaPlayer.OnCompletionListener() {
                    @Override
                    public void onCompletion(MediaPlayer mp) {
                        player.stop();
                        player.release();
                    }
                });
            }

            EndAct = false;
            ActionCnt++;
            PeakIdx = 0;
            PeakValue = 0;
        }
    }

    // 그래프 비교 함수
    private void SetText()
    {
        // ------------- Compare ------------
        // 버튼
        final TextView Count = (TextView) findViewById(R.id.counter);
        final TextView Time = (TextView) findViewById(R.id.time);
        final TextView Big_t = (TextView) findViewById(R.id.B);
        final TextView Small_t = (TextView) findViewById(R.id.SM);
        final TextView R_G = (TextView) findViewById(R.id.G1);
        final TextView Fast_t = (TextView) findViewById(R.id.F);
        final TextView Slow_t = (TextView) findViewById(R.id.SL);
        final TextView S_G = (TextView) findViewById(R.id.G2);
        final TextView accu = (TextView) findViewById(R.id.acc);

        String sacc = String.format("%.1f",(end_time - start_time)/1000.0);
        String accura = String.format("%.1f", (acc / ActionCnt)*100);

        Count.setText("운동 횟수 : " +Integer.toString(ActionCnt) + "회");
        Time.setText("운동 시간 : " + sacc + "초");
        Big_t.setText(Integer.toString(big)+ "회");
        Small_t.setText(Integer.toString(small)+ "회");
        R_G.setText(Integer.toString(range_good)+ "회");
        Fast_t.setText(Integer.toString(fast)+ "회");
        Slow_t.setText(Integer.toString(slow)+ "회");
        S_G.setText(Integer.toString(speed_good)+ "회");
        accu.setText("정확도 : " +accura + "%");

    }

    private void SetText2()
    {
        // ------------- Compare ------------
        // 버튼
        final TextView Count = (TextView) findViewById(R.id.counter);
        final TextView Time = (TextView) findViewById(R.id.time);
        final TextView Big_t = (TextView) findViewById(R.id.B);
        final TextView Small_t = (TextView) findViewById(R.id.SM);
        final TextView R_G = (TextView) findViewById(R.id.G1);
        final TextView Fast_t = (TextView) findViewById(R.id.F);
        final TextView Slow_t = (TextView) findViewById(R.id.SL);
        final TextView S_G = (TextView) findViewById(R.id.G2);
        final TextView accu = (TextView) findViewById(R.id.acc);


        Count.setText("운동 횟수 : 0회");
        Time.setText("운동 시간 : 초");
        Big_t.setText(Integer.toString(big)+ "회");
        Small_t.setText(Integer.toString(small)+ "회");
        R_G.setText(Integer.toString(range_good)+ "회");
        Fast_t.setText(Integer.toString(fast)+ "회");
        Slow_t.setText(Integer.toString(slow)+ "회");
        S_G.setText(Integer.toString(speed_good)+ "회");
        accu.setText("정확도 : %");

    }
}