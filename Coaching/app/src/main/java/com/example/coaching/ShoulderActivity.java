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
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import com.github.mikephil.charting.charts.LineChart;
import com.github.mikephil.charting.data.Entry;
import com.github.mikephil.charting.data.LineData;
import com.github.mikephil.charting.data.LineDataSet;
import com.github.mikephil.charting.interfaces.datasets.ILineDataSet;

import java.util.ArrayList;

import static java.lang.Thread.sleep;

public class ShoulderActivity extends AppCompatActivity {

    double[] shoulderBaseGyroZ = {
            0.083973,
            0.038587,
            -0.011725,
            -0.049851,
            -0.019619,
            -0.133504,
            -0.136604,
            -0.420103,
            -0.670106,
            -0.817193,
            -0.858437,
            -1.06091,
            -1.347349,
            -1.354828,
            -1.361901,
            -1.426194,
            -0.921316,
            -0.523621,
            -0.42414,
            -0.237728,
            -0.173387,
            -0.055269,
            -0.013218,
            0.03343,
            0.08616,
            0.075174,
            0.145136,
            0.432959,
            0.764085,
            0.849176,
            1.048855,
            1.146667,
            1.408566,
            1.281751,
            0.9053,
            0.566425,
            0.630539,
            0.574412,
            0.540407,
            0.380027,
            0.147889,
            0.008401,
            0.01223,
            -0.018272,
            -0.01982,
            -0.048718,
            -0.132144,
            -0.303495,
            -0.518955,
            -0.722136,
            -0.817063,
            -1.21479,
            -1.333117,
            -1.421979,
            -1.202433,
            -1.055076,
            -1.022666,
            -0.525964,
            -0.493667,
            -0.579423,
            -0.266197,
            0.014382,
            0.049369,
            0.01896,
            0.054256,
            0.055538,
            0.080869,
            0.357904,
            0.921482,
            1.152201,
            0.942035,
            1.142847,
            1.408036,
            1.098491,
            1.299673,
            0.805293,
            0.608843,
            0.545543,
            0.45125,
            0.221309,
            0.10422,
            -0.026498,
            -0.079479,
            -0.041474,
            0.000122,
            -0.018577,
            -0.285749,
            -0.503153,
            -0.824829,
            -0.846862,
            -1.246929,
            -1.287856,
            -1.070556,
            -1.08584,
            -0.932452,
            -0.887676,
            -0.661202,
            -0.408592,
            -0.54828,
            -0.410152,
            -0.004157,
            0.052242,
            0.058724,
            0.10093,
            0.218867,
            0.50103,
            0.862902,
            0.887313,
            0.991859,
            1.210847,
            1.355374,
            1.15597,
            1.140858,
            0.949571,
            0.808615,
            0.634613,
            0.29254,
            0.046579,
            -0.035845,
            -0.134585,
            -0.032819,
            -0.015603,
            -0.061593,
            -0.196703,
            -0.531969,
            -0.685219,
            -1.032979,
            -1.328264,
            -1.253838,
            -1.415031,
            -1.488446,
            -1.070773,
            -0.525147,
            -0.270359,
            -0.112817,
            -0.041487,
            0.1377,
            0.096402,
            0.030038,
            -0.003232,
            0.028933,
            0.147275,
            0.492274,
            0.687064,
            0.844841,
            1.066693,
            1.199552,
            1.165554,
            1.270685,
            1.000196,
            0.785615,
            0.495157,
            0.41957,
            0.406368,
            0.095781,
            -0.042465,
            -0.065611,
            -0.04865,
            -0.132106,
            -0.142578,
            -0.451606,
            -0.734394,
            -0.96054,
            -1.045362,
            -0.831773,
            -0.933684,
            -0.946367,
            -0.743667,
            -0.790551,
            -0.769978,
            -0.439707,
            -0.601146,
            -0.415053,
            -0.125672,
            -0.055813,
            0.034963,
            0.056487,
            0.169358,
            0.415705,
            0.746099,
            0.749426,
            0.951326,
            1.39697,
            1.310041,
            1.153976,
            0.901417,
            0.675413,
            0.55386,
            0.463166,
            0.197363,
            0.000789,
            -0.076012,
            -0.017349,
            0.003416,
            -0.000666,
            -0.376891,
            -0.631164,
            -0.779658,
            -0.981232,
            -1.232406,
            -1.4733,
            -1.434004,
            -1.140723,
            -0.761022,
            -0.367625,
            -0.418697,
            -0.232154,
            0.142705,
            0.069366,
            0.073599,
            0.055267,
            0.145576,
            0.483999,
            0.762839,
            0.841254,
            0.845707,
            1.006546,
            1.101579,
            0.96786,
            0.865923,
            0.888383,
            0.724048,
            0.588497,
            0.08131,
            0.003223,
            0.027706,
            -0.01954,
            -0.032729,
            -0.091506,
            -0.334829,
            -0.570824,
            -0.678507,
            -1.036545,
            -0.991088,
            -1.269718,
            -1.515586,
            -1.358188,
            -0.892682,
            -0.445663,
            -0.446917,
            -0.149615,
            0.065648,
            0.056182,
            0.018147,
            0.0388,
            0.19794,
            0.523342,
            0.626047,
            0.832785,
            1.089698,
            1.099035,
            1.157456,
            1.159137,
            0.942536,
            0.631092,
            0.456891,
            0.320277,
            0.079272,
            0.079979,
            0.021382,
            0.021032,
            0.011356,
            -0.062589,
            -0.406665,
            -0.661083,
            -0.784232,
            -0.840108,
            -1.245644,
            -1.480158,
            -1.39914,
            -1.195374,
            -0.89632,
            -0.493695,
            -0.289941,
            0.1111,
            0.235099,
            0.245841,
            0.171761,
            0.126668,
            0.282677,
            0.697649,
            0.754256,
            0.946546,
            1.222884,
            1.092294,
            1.352634,
            1.045231,
            0.681206,
            0.531891,
            0.331555,
            0.164089,
            -0.028049,
            0.011067,
            -0.027398,
            -0.178752,
            -0.497601,
            -0.634565,
            -1.016031,
            -1.527731,
            -1.484305,
            -1.151859,
            -1.2713,
            -1.247067,
            -0.617576,
            -0.180256,
            -0.289033,
            -0.078702,
            0.109806,
            0.204127,
            0.286883,
            0.470662,
            0.773783,
            0.968103,
            1.095202,
            1.035323,
            1.149661,
            1.004091,
            0.873118,
            0.824536,
            0.617314,
            0.178506,
            -0.030123,
            -0.140979,
            -0.000534,
            -0.043176,
            -0.129383,
            -0.150741,
            -0.335004,
            -0.563346,
            -0.873675,
            -1.217351,
            -1.597425,
            -1.435547,
            -1.371495,
            -0.996373,
            -0.456791,
            -0.475871,
            -0.547912,
            -0.062943,
            0.174134,
            0.025122,
            -0.011379,
            0.081215,
            0.055359,
            -0.019918,
            -0.065091,
            -0.033627,
            -0.064269,
            -0.05789
    };

    private int shoulderBaseGyroZPeakIdx_each = 84;
    private double shoulderBaseGyroZPeakValue_each =  1.034309;
    private int shoulderBaseGyroZStartIdx_each =162;
    private int shoulderBaseGyroZEndIdx_each = 164;
    private int shoulderBaseGyroZ_Distance = shoulderBaseGyroZEndIdx_each - shoulderBaseGyroZStartIdx_each; // 2



    private int[] shoulderBaseGyroZPeakIdx = {84,124,162,200,234,269,303,337,367}; // 원본과 -62 인덱스차이
    private double[] shoulderBaseGyroZPeakValues = {1.408566,1.408036,1.355374,1.270685,1.39697,1.101579,1.157456,1.352634,1.149661};

    // ----------------- 여기까지 Baseline Data -----------------

    // 윗몸일으키기 User's data
    double[] shoulderUserGyroZ = new double[10000];
    private ArrayList<Integer> shoulderUserGyroZPeakIdx = new ArrayList<>();
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
        setContentView(R.layout.activity_shoulder);

        ArrayList<Entry> values = new ArrayList<>(); // x,y좌표 [x, 자이로값]
        for(int i = 0; i < 2 * shoulderBaseGyroZ.length; i++)
        {
            float val = (float) shoulderBaseGyroZPeakValue_each;
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
        mGyroLis = new ShoulderActivity.GyroscopeListener();

        mAccelometerSensor = mSensorManager2.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);
        mAccLis = new ShoulderActivity.AccelometerListener();

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
                        shoulderUserGyroZ[i] = 0;
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
            double GyroZ = event.values[0];
            double gyroY = event.values[1];
            double gyroZ = event.values[2];

            // 리스트에 추가 및 실시간 비교
            shoulderUserGyroZ[idxGyro] = gyroZ;
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
            if(PeakValue > shoulderBaseGyroZPeakValue_each)
            {
                acc += (shoulderBaseGyroZPeakValue_each - (PeakValue - shoulderBaseGyroZPeakValue_each)) / shoulderBaseGyroZPeakValue_each;
            }
            else
            {
                acc += PeakValue / shoulderBaseGyroZPeakValue_each;
            }

            // ------------- Compare -------------
            double difference = 0.05; // 오차
            // 1. 동작 크기 비교
            if (PeakValue > shoulderBaseGyroZPeakValue_each * (1 + difference)) // 동작이 크다
            {
                big++;

            } else if (PeakValue < shoulderBaseGyroZPeakValue_each * (1 - difference)) // 동작이 작다
            {
                small++;

            } else // 적당한 동작
            {
                range_good++;
            }

            // 2. 동작 속도 비교
            if (EndIdx - PeakIdx > shoulderBaseGyroZ_Distance + 2) // 동작이 느리다
            {
                slow++;

            } else if (EndIdx - PeakIdx < shoulderBaseGyroZ_Distance - 2) // 동작이 빠르다
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