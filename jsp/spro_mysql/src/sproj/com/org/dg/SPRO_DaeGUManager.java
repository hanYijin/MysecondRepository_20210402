package sproj.com.org.dg;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

import sproj.com.org.DBInfo;
import sproj.com.org.SPRO_MEMBER;

public class SPRO_DaeGUManager {
	public String selectStr() {
		
		Connection conn = null; //DB ¿¬°á°´Ã¼
		PreparedStatement pstmt= null;
		ResultSet rs =null;
		//String ret =[ 300, 150, 200, 100,20);
		String ret = "[";
		try {
			Class.forName(DBInfo.mysql_class);
			conn= DriverManager.getConnection(DBInfo.mysql_url, DBInfo.mysql_id, DBInfo.mysql_pw);
			pstmt= conn.prepareStatement("select code2_name as name, count(*)/10 as cnt"+" from daegu " + 
					" group by code2_name" + 
					" limit 10,5;");
			rs= pstmt.executeQuery();
			
			while(rs.next()) {
				if(rs.isLast())
					ret += rs.getInt("cnt");
				else
					ret += rs.getInt("cnt")+",";
						
				
			}
			ret +="]";
		
			
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
		}return ret;
	}
	
	
	
	
	
	public List<SPRO_DaeGU> select(int pageNum) {
		List<SPRO_DaeGU> list = new ArrayList<SPRO_DaeGU>();
		pageNum=0;
		Connection conn = null; //DB ¿¬°á°´Ã¼
		PreparedStatement pstmt= null;
		ResultSet rs =null;
		try {
			Class.forName(DBInfo.mysql_class);
			conn= DriverManager.getConnection(DBInfo.mysql_url, DBInfo.mysql_id, DBInfo.mysql_pw);
			pstmt= conn.prepareStatement("SELECT * FROM daegu limit "+ pageNum +", 10");
			rs= pstmt.executeQuery();
			
			while(rs.next()) {
				SPRO_DaeGU sd= new SPRO_DaeGU();
				
				sd.setIdx(rs.getInt("idx"));
				sd.setName(rs.getString("name"));
				sd.setCode1(rs.getString("code1"));
				sd.setCode1_name(rs.getString("code1_name"));
				sd.setCode2(rs.getString("code2"));
				sd.setCode2_name(rs.getString("code2_name"));
				sd.setCode4(rs.getString("code4"));
				sd.setCode4_name(rs.getString("code4_name"));
				sd.setDoro_addr(rs.getString("doro_addr"));
				list.add(sd);
				
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
		}return list;
	}
}
