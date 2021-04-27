<%@page import="sproj.com.org.SPRO_DBManager"%>
<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<%
	String seat= request.getParameter("seat");
	String name= (String)session.getAttribute("name");
	String phone= (String)session.getAttribute("phone");
	String m_time="3";
	
	SPRO_DBManager sdbm= new SPRO_DBManager();
	int ret= sdbm. seat_useInsert(seat,name,phone,m_time);
	if(ret>0){
		out.println("좌석 선택이 완료되었습니다.");
	}
	else{
		out.println("좌석 선택 실패하였습니다");
	}
%>