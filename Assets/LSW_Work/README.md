# UnityGitTest
 깃을 통한 유니티 생성
 LSW 브랜치 생성 - MD 파일 추가

UI + Map

Lobby
    게임시작 - Button(GameStart())
    이어하기 - Button(ReStart())
    환경설정 - Button(Setting())
    게임종료 - Button(End())

OnGame
레벨 1
    레벨 1 Map, 플레이어 몬스터 스폰 좌표
레벨 2
    레벨 2 Map, 플레이어 몬스터 스폰 좌표

환경설정
    밝기 조절
        image 투명도 조절 - UIManager
    음량 조절
        Slider - audioManager
    키 설정
        InputManager - 입력 null 기본 키 등록, 입력값 키 등록

GameOver
    게임 오버 안내 문구 - Text
    다시하기 - Button
    게임종료 - Button

BGM
    Lobby
    OnGame
    GameOver
    환경설정 현재 있는 씬 BGM
