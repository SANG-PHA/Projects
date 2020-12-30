작품 개요
-----------

손 기능의 장애를 가진 환자들을 위한 악력 재활 기계.   
일반적으로 사용하는 악력기는 지루하고 힘이 많이드는 반복적 운동이다.   
이를 해결하기 위해 악력기에 압력센서를 부착하고, 아두이노 나노를 통해 압력센서의 신호를 컴퓨터로 전달한다.   
컴퓨터로 전달된 압력센서의 신호값에 따라 2D 레이싱 게임의 캐릭터를 제어할 수 있다.   
게임은 최대 2명의 플레이어까지 즐길 수 있으며, 일반적으로는 컴퓨터와 아두이노 나노를 케이블로 연결하여 사용하지만   
필요에 따라 블루투스 모듈을 사용하여 무선으로도 사용할 수 있다.

##### 작품 사진
<img src = "https://user-images.githubusercontent.com/68215551/103323918-6971b780-4a88-11eb-9add-44af2537e0ed.jpg" width="40%" height="15%" hspace="20"> <img src = "https://user-images.githubusercontent.com/68215551/103323917-68408a80-4a88-11eb-9352-de495b1720a7.jpg" width="40%" height="15%">  


##### 실행 흐름도 , 통신 처리 흐름도
<img src = "https://user-images.githubusercontent.com/68215551/103323882-392a1900-4a88-11eb-9299-4ee396b74c59.png" width="310px" height="142px" hspace="40"> <img src = "https://user-images.githubusercontent.com/68215551/103323883-3af3dc80-4a88-11eb-8106-984dcc679d7a.png" width="142px" height="162px">

##### 하드웨어 구성
<img src = "https://user-images.githubusercontent.com/68215551/103324923-a9d33480-4a8c-11eb-968e-1a610e4e99e0.png" width="60%">

##### 소프트웨어 구성
<img src = "https://user-images.githubusercontent.com/68215551/103324925-a9d33480-4a8c-11eb-9b4c-3b805c458ec0.png" width="60%">


<br/><br/><br/><br/><br/><br/>

실행 과정
---------

<img src = "https://user-images.githubusercontent.com/68215551/103324926-aa6bcb00-4a8c-11eb-90a1-401557552207.JPG" width="70%">

##### 1. 악력기에 부착된 압력센서를 통해 사용을 감지할 수 있으므로 사용자는 악력 운동만 수행하면 된다. <br/><br/>

<img src = "https://user-images.githubusercontent.com/68215551/103324920-a8a20780-4a8c-11eb-8828-c09a5a88efee.JPG" width="70%">

##### 2. 사용자가 조종하는 비행기는 일정한 속도를 가지고 오른쪽으로 움직인다. 사용자가 힘을 주면 압력센서에 감지된 값 만큼 위로 움직이고, 힘을 빼면 아래로 움직인다.

<img src = "https://user-images.githubusercontent.com/68215551/103324922-a93a9e00-4a8c-11eb-9732-cd054e73679a.JPG" width="70%">

##### 3. 캐릭터가 장애물에 걸리거나 벽에 부딫히면 게임이 종료된다.

<br/><br/><br/><br/><br/><br/>
   
의학적 효과
-----------

1. 노인을 대상으로 한 사망률의 예측에서 악력은 유의미한 통계적 수치를 가진다 [1].
2. 중년의 악력을 통해 노년의 기능적 한계 및 장애를 예측 가능하다 [2].
3. 악력은 신체 활동의 지표가 될 수 있으며 그 자체로 기능을 보존하고 장애를 예방할 수 있다 [3].
4. 악력은 많은 일상적인 기능과 스포츠 활동에 필수적이다 [4].
5. 운동선수들에게 악력은 부상 예방에 중요한 역할을 한다 [4].

###### 참고 문헌
[1] *Catharine R Gale, Christopher N Martyn, Cyrus Cooper, Avan Aihie Sayer. “Grip strength, body composition, and mortality”. International Journal of Epidemiology, Volume 36, Issue 1, February 2007, Pages 228–235.*   
[2] *Taina Rantanen, PhD; Jack M. Guralnik, MD, PhD; Dan Foley, MSc; et al. “Midlife Hand Grip Strength as a Predictor of Old Age Disability”. JAMA. 1999;281(6):558-560. doi:10.1001/jama.281.6.558*   
[3] *Poitras, Colin. Grip Strength is good indicator of overall health. 6 June 2011. https://today.uconn.edu/2011/06/grip-strength-is-good-indicator-of-overall-health/#. 24 September 2018.*   
[4] *Shea, Jason. THE IMPORTANCE OF GRIP. 11/2014.*
