<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>
	<div class="umbotron">
		<h1>STUDY CAFE</h1>
		<p>열공하자!</p>
		<% 
			Object name=session.getAttribute("name");
			if(name!=null){
		%>
			<P>안녕하세요 <% out.println((String)name); %>님 :)</P>
			
	</div>
</body>
</html>