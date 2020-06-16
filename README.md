# Discord My Token
자신의 토큰을 쉽게 알 수 있는 프로그램입니다. <br>
Program.cs 에 모든 코드가 있습니다. <br>
<a href="https://github.com/1-EXON/Discord-Token-Grabber/blob/master/TokenGrabber/TokenGrabber/Program.cs" target="_blank">소스코드 바로 보기
</a>

<b>※저는 이 프로그램을 자신의 토큰을 쉽게 알 수 있고록 제작한 것 뿐이고 만일 이 코드를 악용할 경우, 책임은 사용자에게 있습니다</b>

## 사용법
1. [다운로드](https://github.com/1-EXON/Discord-Token-Checker/archive/v1.0.zip)한 다음 압축을 푼다. <br>
2. exe 파일을 실행한다.
3. 자신의 디스코드 토큰이 출력된다.

## 원리
1. 디스코드 Path 로컬스토리지에 있는 ldb 파일을 불러옴
2. 문자열 "token" 이 들어간 파일을 찾음
3. 정규식으로 파일을 찾은 것을 하나하나 나눔
4. 나눈 문자열의 글자수가 59개(토큰의 글자수) 이고 .(마침표)가 포함된 것을 찾음
5. 출력함
