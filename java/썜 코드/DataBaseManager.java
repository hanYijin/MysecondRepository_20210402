import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;

import javax.swing.JOptionPane;

// �����ͺ��̽��Ŵ���Ŭ������ �׼Ǹ������̴�..is a ���� ����..
public class DataBaseManager implements ActionListener{
	
//	try :
//	except Exception as e:
//		print(e)
//	finally:
	
//  form ����... �޴�������.. 
//  jar ���̺귯��.. add jar
//  pip install selenium
//  ctrl + shift + o
	@Override
	public void actionPerformed(ActionEvent e) {
		Connection conn = null; // �����ͺ��̽� ���ᰴü
		PreparedStatement pstmt = null;
		
		try {
			Class.forName("oracle.jdbc.driver.OracleDriver");
			
			conn = DriverManager
					.getConnection("jdbc:oracle:thin:@192.168.0.111:1521:xe",
							"AI", "1234");
			pstmt = conn.prepareStatement("insert into atable values(?,?,?,?)");
			pstmt.setInt(1, Integer.parseInt(Ex01.tf_idx.getText()));
			pstmt.setString(2, Ex01.tf_name.getText());
			pstmt.setString(3, Ex01.tf_gender.getText());
			pstmt.setString(4, Ex01.tf_remark.getText());
			pstmt.executeUpdate();
			
		}
		catch (ArithmeticException ae) {
			JOptionPane.showMessageDialog(null, "0���� ���� �� ����.");
		}
		catch (ClassNotFoundException cne) {
			JOptionPane.showMessageDialog(null, "Ŭ���� ����.");
		}
		// �ϴٰ� ���ܻ�Ȳ�� �߻��ϸ� catch�� ������... 
		catch (Exception exc) {
			exc.printStackTrace();
		}
		finally {
			try {
				if(pstmt != null) pstmt.close();
				if(conn != null) conn.close();
			}catch (Exception closee) {}
		}
		System.out.println("�����ͺ��̽��޴���..");
	}

}





