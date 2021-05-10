<%@page import="sproj.com.org.dg.SPRO_DaeGUManager"%>
<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<%
 	SPRO_DaeGUManager sdgm = new SPRO_DaeGUManager();
	String ret= sdgm.selectStr();
	System.out.println(ret);
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script	src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="/sproj/css/mycss.css"/>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <script src="http://d3js.org/d3.v6.min.js" charset="UTF-8"></script>
    <style type="text/css">
    	ret{
    		stroke : rgb(100,0,0);
    		stroke-width: 1px;
    		fill : rgb(124,235,100);
    		
    	}
    </style>
</head>
<body>
	<div class="jumbotron">
		<h1>My Study</h1>
		<p>code2 분류별 데이터</p>
		<svg id="myGraph" width="1000">
       		<!--<rect x="10" y="30" width="100" height="80"/>-->
    </svg>
    <script src="../js/sample07.js"></script>
	</div>
</body>
</html>
<script src="../js/sample07.js"></script>
<script type="text/javascript">
	doGra(<%=ret%>);
</script>