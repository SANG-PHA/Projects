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

public class LungeActivity extends AppCompatActivity {

    double[] lungeBaseGyroZ = {
            -0.025286,
            -0.110937,
            -0.28703,
            -0.493474,
            -0.560392,
            -0.828752,
            -0.947118,
            -1.957587,
            -1.404724,
            -0.210098,
            -0.243417,
            -0.764885,
            -0.783125,
            -0.333238,
            -0.598145,
            -0.40975,
            -0.287951,
            0.004165,
            0.105268,
            0.069682,
            0.126433,
            0.022154,
            -0.021114,
            0.101935,
            0.121262,
            0.612641,
            0.421989,
            0.783506,
            0.463963,
            0.607452,
            0.547228,
            0.15663,
            0.454429,
            0.196831,
            0.497743,
            0.188923,
            0.065449,
            0.421626,
            0.170324,
            0.001419,
            -0.07974,
            -0.011441,
            0.091911,
            -0.089609,
            -0.028267,
            -0.136636,
            -0.061037,
            -0.09911,
            -0.100596,
            -0.326375,
            -0.537034,
            -0.304515,
            -0.630032,
            -0.767889,
            -0.71952,
            -0.450696,
            -0.080741,
            -0.269758,
            -0.577335,
            -0.478344,
            -0.387986,
            -0.408014,
            -0.543924,
            -0.153505,
            -0.406789,
            -0.047182,
            0.35323,
            -0.008628,
            0.149428,
            0.121948,
            -0.224045,
            0.162002,
            0.348018,
            0.431372,
            0.483369,
            0.545297,
            0.46595,
            0.349157,
            0.40816,
            0.375878,
            0.250992,
            0.313669,
            0.301184,
            0.40852,
            0.182336,
            0.220612,
            0.400661,
            0.315079,
            -0.095605,
            0.136747,
            0.115828,
            -0.084819,
            0.010904,
            0.082292,
            -0.079413,
            -0.208323,
            -0.604199,
            -0.635081,
            -0.233796,
            -0.50928,
            -0.763322,
            -0.508105,
            -0.235138,
            -0.378071,
            -0.210174,
            -0.454745,
            -0.222575,
            -0.252765,
            -0.206436,
            -0.120319,
            -0.068728,
            0.166614,
            -0.170557,
            0.078937,
            -0.003803,
            0.068333,
            0.059278,
            -0.020107,
            0.206327,
            0.146847,
            0.166352,
            0.630862,
            0.110228,
            0.236739,
            0.300683,
            0.361925,
            0.436157,
            -0.045554,
            0.137544,
            0.233469,
            0.19645,
            0.449691,
            0.492701,
            0.302517,
            0.257694,
            0.112256,
            -0.223624,
            0.054053,
            0.017496,
            -0.173429,
            -0.214202,
            -0.367846,
            -0.713606,
            -0.612614,
            -0.2347,
            -0.440776,
            -0.613337,
            -0.484479,
            -0.287788,
            -0.305424,
            -0.26837,
            -0.306029,
            -0.206025,
            -0.251819,
            -0.192871,
            -0.144122,
            0.271128,
            -0.152324,
            0.057829,
            -0.037154,
            0.065875,
            0.074367,
            0.27575,
            0.371832,
            0.347586,
            0.460418,
            0.123344,
            0.559526,
            0.360798,
            0.272689,
            -0.052192,
            0.439067,
            0.477482,
            0.184473,
            -0.094912,
            0.281676,
            0.253676,
            0.199064,
            0.018741,
            0.031158,
            0.136287,
            -0.172871,
            -0.416325,
            -0.365706,
            -0.521785,
            -0.389901,
            -0.542819,
            -0.243095,
            -0.269039,
            -0.495611,
            -0.636664,
            -0.370627,
            -0.395763,
            -0.328481,
            -0.188715,
            -0.312594,
            -0.007263,
            -0.050877,
            0.147511,
            -0.020068,
            0.159278,
            0.099052,
            0.032931,
            -0.038955,
            -0.014232,
            0.18195,
            0.514418,
            0.215644,
            0.651738,
            0.051168,
            0.425556,
            0.487977,
            0.252445,
            0.102843,
            0.105778,
            0.190038,
            0.689809,
            0.144528,
            0.05552,
            0.224912,
            -0.031298,
            0.103937,
            -0.026824,
            -0.049354,
            0.135257,
            -0.043214,
            -0.166949,
            -0.394368,
            -0.359672,
            -0.33553,
            -0.231681,
            -0.631512,
            -0.539617,
            -0.088884,
            -0.338786,
            -0.490759,
            -0.52166,
            -0.358119,
            -0.160169,
            -0.160492,
            -0.236034,
            0.061257,
            0.176975,
            -0.228548,
            0.022889,
            0.051373,
            0.20747,
            0.074135,
            0.367394,
            0.149571,
            0.529198,
            0.335391,
            0.239321,
            0.398591,
            -0.049552,
            0.154062,
            0.340963,
            0.405154,
            0.271169,
            0.244494,
            0.286498,
            0.355044,
            -0.066514,
            -0.204991,
            0.263755,
            -0.211639,
            -0.154929,
            -0.327893,
            -0.467969,
            -0.405239,
            -0.455628,
            -0.15474,
            -0.200826,
            -0.840009,
            -0.224048,
            -0.265123,
            -0.492848,
            -0.260358,
            -0.131058,
            -0.337396,
            0.186806,
            -0.022623,
            0.042935,
            -0.069244,
            0.037317,
            -0.046222,
            0.07284,
            0.273879,
            0.33045,
            0.449805,
            0.169288,
            0.289259,
            0.418169,
            0.180575,
            0.107606,
            0.270648,
            -0.055344,
            0.288753,
            0.388841,
            0.470145,
            0.189006,
            0.011501,
            0.161548,
            -0.001893,
            -0.069002,
            -0.044035,
            -0.140163,
            -0.32428,
            -0.317993,
            -0.3799,
            -0.308103,
            -0.553091,
            -0.409585,
            -0.185834,
            -0.328278,
            -0.323095,
            -0.35671,
            -0.353928,
            -0.374183,
            -0.393385,
            0.084991,
            -0.099268,
            -0.287324,
            0.195775,
            0.069256,
            0.107673,
            0.231497,
            0.154706,
            0.187212,
            0.246685,
            0.301703,
            0.27004,
            0.329092,
            0.320631,
            0.343477,
            0.345442,
            0.077991,
            0.099296,
            0.387158,
            0.187794,
            0.034193,
            0.008739,
            -0.058216,
            0.081224,
            -0.150301,
            -0.355915,
            -0.586142,
            -0.547051,
            0.079977,
            -0.498957,
            -0.442333,
            -0.211853,
            -0.084502,
            -0.308326,
            -0.212466,
            -0.273883,
            -0.103878,
            0.010065,
            0.165632,
            0.231916,
            0.099164,
            0.030481,
            0.117281,
            0.048402,
            0.053817,
            -0.07507,
            0.237596,
            0.055199,
            0.185629,
            0.752095,
            0.453927,
            -0.022048,
            0.250251,
            0.106718,
            0.175622,
            0.182811,
            0.257631,
            0.022818,
            0.313442,
            -0.090762,
            0.039293,
            -0.105121,
            -0.290942,
            -0.13839,
            -0.482448,
            -0.277692,
            -0.563852,
            -0.2892,
            -0.335973,
            -0.234361,
            -0.359799,
            -0.217387,
            -0.197598,
            -0.341486,
            0.13045,
            0.276396,
            -0.118483,
            0.091539,
            0.135874,
            0.095147,
            0.454865,
            0.364507,
            0.164767,
            0.107086,
            0.197392,
            0.164366,
            0.175888,
            0.380761,
            0.094053,
            0.133698,
            0.480896,
            0.230967,
            -0.104196,
            0.307811,
            0.192064,
            0.060581,
            0.578626,
            0.650724,
            1.233721,
            0.867085,
            0.180262,
            0.061363,
            -0.401601,
            -0.81413,
            -0.288434,
            0.117808,
            -0.156705,
            -0.07492,
            -0.163812,
            -0.095171,
            -0.030491,
            -0.15649,
            -0.023378,
            -0.127512,
            -0.142159,
            -0.068965,
            -0.093602,
            -0.060102

    };

    private int lungeBaseGyroZPeakIdx_each = 85;
    private double lungeBaseGyroZPeakValue_each = -3.9;
    private int lungeBaseGyroZStartIdx_each = 140;
    private int lungeBaseGyroZEndIdx_each = 149;
    private int lungeBaseGyroZ_Distance = lungeBaseGyroZEndIdx_each - lungeBaseGyroZStartIdx_each; // 9


    private int[] lungeBaseGyroZPeakIdx = {84, 124, 162, 200, 234, 269, 303, 337, 367, 400}; // 원본과 -62 인덱스차이
    private double[] lungeBaseGyroZPeakValues = {1.408566, 1.408036, 1.355374, 1.270685, 1.39697, 1.101579, 1.157456, 1.352634, 1.149661, 1.21321};

    // ----------------- 여기까지 Baseline Data -----------------

    // 윗몸일으키기 User's data
    double[] lungeUserGyroZ = new double[10000];
    private ArrayList<Integer> lungeUserGyroZPeakIdx = new ArrayList<>();
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
        setContentView(R.layout.lunge);

        ArrayList<Entry> values = new ArrayList<>(); // x,y좌표 [x, 자이로값]
        for(int i = 0; i < 2 * lungeBaseGyroZ.length; i++)
        {
            float val = (float) lungeBaseGyroZPeakValue_each;
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
        mGyroLis = new LungeActivity.GyroscopeListener();

        mAccelometerSensor = mSensorManager2.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);
        mAccLis = new LungeActivity.AccelometerListener();

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
                        lungeUserGyroZ[i] = 0;
                    idxGyro = 0;
                    big = 0; small = 0; correct = 0; slow = 0; fast = 0; range_good = 0; speed_good = 0; ActionCnt = 0;  start = 0; acc= 0;
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
            lungeUserGyroZ[idxGyro] = gyroZ;
            compare_each(gyroZ, idxGyro);
            idxGyro++;

            // 그래프 그리기
            values_.add(new Entry(idxGyro, (float)gyroZ));

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
        if(pre_val < -2.0 && value > -2.0)
        {
            EndIdx = idx;
            EndAct = true;
        }

        // 피크 찾기
        if(value < PeakValue && value < -3.0)
        {
            PeakIdx = idx;
            PeakValue = value;
        }

        pre_val = value;

        if(EndAct) {
            start++;
            // 정확도 계산
            if(PeakValue < lungeBaseGyroZPeakValue_each)
            {
                acc += (Math.abs(lungeBaseGyroZPeakValue_each) - (Math.abs(PeakValue) - Math.abs(lungeBaseGyroZPeakValue_each))) / Math.abs(lungeBaseGyroZPeakValue_each);
            }
            else
            {
                acc += Math.abs(PeakValue) / Math.abs(lungeBaseGyroZPeakValue_each);
            }

            // ------------- Compare -------------
            double difference = 0.05; // 오차
            // 1. 동작 크기 비교
            if (PeakValue < lungeBaseGyroZPeakValue_each * (1 + difference)) // 동작이 크다
            {
                big++;

            } else if (PeakValue > lungeBaseGyroZPeakValue_each * (1 - difference)) // 동작이 작다
            {
                small++;

            } else // 적당한 동작
            {
                range_good++;
            }

            // 2. 동작 속도 비교
            if (EndIdx - PeakIdx > lungeBaseGyroZ_Distance + 1) // 동작이 느리다
            {
                slow++;

            } else if (EndIdx - PeakIdx < lungeBaseGyroZ_Distance - 1) // 동작이 빠르다
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