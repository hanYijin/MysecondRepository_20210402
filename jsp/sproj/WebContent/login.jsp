<%@ page language="java" contentType="text/html; charset=EUC-KR" pageEncoding="EUC-KR"%>
<%@ page import="sproj.com.org.SPRO_DBManager" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script	src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</head>
<body>
	<div class="jumbotron">
		<h1>My Study</h1>
		<p>공부하자!</p>
		
		
	</div>
</body>
</html>
<%
	String id=request.getParameter("id");//
	String pw=request.getParameter("pw");
	out.println("id= "+id);
	out.println("pw= "+pw);
	
	SPRO_DBManager sdbm = new SPRO_DBManager();
	int ret = sdbm.CKLogin(id,pw);
	if(ret==0)
	{
		out.println("로그인 성공");
	}else{
		out.println("로그인 실패");
	}
%>
