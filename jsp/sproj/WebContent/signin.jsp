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
		padding: 150px 250px;
		box-sizing: border-box;
		}
		
	#sub{
			padding : 2px 100px;
			margin-top: 20px;
			background-color: #F6EFD9;
		}	
		
</style>
</head>
<body>
<div class="container">
	<form action="signproc.jsp" method="get"> <!--"get" 주소줄에 뭘 가져갔는 지보이는 방식 "post"는 주소줄에 보이지 않음  -->
		<table>
			<tr>
				<td>아이디</td>
				<td><input type="text" name ="id"/></td>
			</tr>
			<tr>
				<td>비밀번호</td>
				<td><input type="text" name ="pw"/></td>
			</tr>
			<tr>
				<td>이름</td>
				<td><input type="text" name ="name"/></td>
			</tr>
			<tr>
				<td>전화번호</td>
				<td><input type="text" name ="phone"/></td>
			</tr>
		</table>
		<input type="submit" value="회원가입" id="sub"/>
	</form>

</div>
</body>
</html>