# 원웨이브게임즈 과제

## 설명
Skill 클래스를 상속받아 기능의 역할을 만들었으며, Effect 클래스를 상속받아 기능을 모듈화 했습니다.<br>
Skill 클래스에 있는 Effect List에 기능을 넣어두게 했습니다.<br>
Effect 클래스가 모노비헤이어를 상속받지 않아서 유니티 기능이 쓰기 어려울 거 같아 보여 실제 기능을 담당하는 역할은 모노비헤이어를 상속받은 Actor 클래스로 했습니다.<br>
Effect 클래스는 Actor에게 데이터를 넘겨주는 기능 정도로만 사용했습니다.

## Skill을 상속받은 스크립트
CostSkill.cs : 마나 소모 역할을 하는 클래스입니다.<br>
ProjectileSkill.cs : 투사체 발사 역할을 하는 클래스입니다.<br>
PullSkill.cs : 대상을 끌어오는 역할을 하는 클래스입니다.<br>

## Effect를 상속받은 스크립트
CostEffect.cs : 마나 소모 기능을 담당합니다.<br>
ProjectileEffect.cs : 투사체 발사 기능을 담당합니다. 행위는 Actor 클래스에 정의 된 OnMoveFoward 함수로 실행을 담당합니다.<br>
PullEffect.cs : 대상을 끌어들이는 기능을 담당합니다. 행위는 Actor 클래스에 정의 된 OnPullObject 함수로 실행을 담당합니다.<br>
