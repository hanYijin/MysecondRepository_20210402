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
		<p>��������!</p>
		<% 
			Object name=session.getAttribute("name");
			if(name!=null){
		%>
			<P>�ȳ��ϼ��� <% out.println((String)name); %>�� :)</P>
			
	</div>
</body>
</html>