package Studycafe.com.org;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

public class DBmanager {
	String ora_class="oracle.jdbc.driver.OracleDriver";
	String mysql_class="com.mysql.cj.jdbc.Driver";
	String ora_url="jdbc:oracle:thin:@localhost:1521:xe";
	String mysql_url="jdbc:mysql://127.0.0.1:3306/spro?useUnicode=true&characterEncoding=UTF-8"; // �ѱ� ���� ����
	String mysql_id="root";
	String mysql_pw="1234";
	
	public Member checkLogin(String id, String pw) {
		Member member= null;
		Connection conn=null;
		PreparedStatement pstmt=null;
		ResultSet rs= null;
		try {
			Class.forName(mysql_class);
			conn=DriverManager.getConnection(mysql_url,mysql_id,mysql_pw);
			pstmt=conn.prepareStatement("SELECT * FROM MEMBER " + "WHERE ID=? AND PW=? ");
			pstmt.setString(1, id);
			pstmt.setString(2, pw);
			rs=pstmt.executeQuery();
			
			if(rs.next()) {
				member= new Member();
				member.setId(id);
				member.setPw(pw);
				member.setName(rs.getString("name"));
				member.setPhone(rs.getString("phone"));
			}
		}catch(Exception e) {
			e.printStackTrace();
		}
		finally {
			try {
				if(rs!=null)rs.close();
				if(pstmt!= null)pstmt.close();
				if(conn!= null)conn.close();
			}catch(Exception c) {
			
			}			
		}
		return member;
	}
	public int signInsert(String id, String pw, String name, String phone) {
		
		Connection conn = null;
		PreparedStatement pstmt = null;
		try {
			Class.forName(mysql_class);
			conn=DriverManager.getConnection(mysql_url,mysql_id,mysql_pw);
			pstmt=conn.prepareStatement("INSERT INTO MEMBER (ID,PW,NAME,PHONE) VALUES (?,?,?,?)");
			
			pstmt.setString(1, id);
			pstmt.setString(2, pw);
			pstmt.setString(3, name);
			pstmt.setString(4, phone);
			int ret = pstmt.executeUpdate();
			if(ret>0) {
				System.out.println("���������� insert �Ǿ����ϴ�");
				return ret;
			}
		}catch(Exception e){
			e.printStackTrace();
		}
		finally{
			try{
				if(pstmt != null) pstmt.close();
				if(conn != null) conn.close();
			}catch(Exception ex){
				
			}
		}
		return 0;
	}
	public int seatSelect(String seat, String name, String phone, String time) {
		Connection conn = null;
		PreparedStatement pstmt = null;
		try{
			// ojdbc jar �߰� Ȯ��
			Class.forName(mysql_class);

			conn = 
			DriverManager.getConnection
			(mysql_url, mysql_id, mysql_pw);
			
			// ���� ���� �� ctrl+ shift + x �빮�� ����
			// ���� ���� �� ctrl+ shift + y �ҹ��� ����
			pstmt = conn.prepareStatement(
					"INSERT INTO "+ 
					"SEAT_USE "+
					"(NUM,NAME,PHONE,M_TIME)"+
					"VALUES "+
					"(?,?,?,?)");
			
			pstmt.setString(1, seat);//1��° ?
			pstmt.setString(2, name);//2��° ?
			pstmt.setString(3, phone);//3��° ?
			pstmt.setString(4, time);//4��° ?
					
			int ret = pstmt.executeUpdate();
			if(ret > 0 ){
				System.out.println("���������� insert �Ǿ����ϴ�.");
				return ret;
				
			}
		}
		catch(Exception e){
			e.printStackTrace();
		}
		finally{
			try{
				if(pstmt != null) pstmt.close();
				if(conn != null) conn.close();
			}catch(Exception ex){
				
			}
		}
		return 0;
	}
}