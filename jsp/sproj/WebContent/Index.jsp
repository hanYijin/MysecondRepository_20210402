<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<style type="text/css">
	.container{
		width : 800px;
		height: 500px;
		margin: 0 auto;
		background-color: #C9D9D2;
		padding: 200px 160px;
		box-sizing: border-box;
		}
	#idsearch,#login,#signin,#outroom{
		color:#205864;
		background-color:#F6EFD9;
		margin-top: 10px;
		padding: 5px 10px;
	}
	
</style>
<script type="text/javascript">
	window.onload=function(){
		document.getElementById('idsearch').onclick=function(){
			location.href='idsearch.jsp'; //idsearch.jsp 페이지로 이동
		}
		document.getElementById('login').onclick=function(){
			var id= document.getElementById('id');//입력받은 아이디 변수 저장
			var pw= document.getElementById('pw');//입력받은 비밀번호 변수 저장
			alert('id= '+id.value);
			alert('pw= '+pw.value);
			location.href='login.jsp?id='+id.value+'&pw='+pw.value;
//		location.href='login.jsp'; //login.jsp 페이지로 이동
			
		}
		document.getElementById('signin').onclick=function(){
			location.href='signin.jsp'; //signin.jsp 페이지로 이동
		}
		document.getElementById('outroom').onclick=function(){
			location.href='outroom.jsp'; //outroom.jsp 페이지로 이동
		}
	}
</script>
</head>
<body>
	<div class="container">
		<table>
		<tr>
			<td>아이디</td>
			<td><input type="text" name="id" id="id"/></td>
			<td>비밀번호</td>
			<td><input type="text" name="pw" id="pw"/></td>
		</tr>
		<tr>
			<td><input type="button" value="ID찾기" id="idsearch"></td>
			<td><input type="button" value="로그인" id="login"></td>
			<td><input type="button" value="회원가입" id="signin"></td>
			<td><input type="button" value="퇴실" id="outroom"></td>
		</tr>
		</table>
	</div>
</body>
</html>