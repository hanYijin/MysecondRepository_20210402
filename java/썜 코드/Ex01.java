import java.awt.Font;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

/*
 * ȭ�� ���� �ϴ� GUI -> �׷��� ����� ����
 * 
 * java -> jframe, javaFx ���߾��...
 * c# -> Form -> ����� OS -> ������..
 * python -> pyQt5, matplotlib.pyplot
 * 
 */
public class Ex01 extends JFrame{
	
	public static int k = 1;
	
	JButton btn1 = new JButton("�Է�");
	DataBaseManager dbm = new DataBaseManager();
	public static JTextField tf_idx;
	public static JTextField tf_name;
	public static JTextField tf_gender;
	public static JTextField tf_remark;
	
	// Ex01 �� JFrame �̴�
	Ex01(){
		getContentPane().setLayout(null); // ��ư �� ���� �� ������..
		
		JLabel lblNewLabel = new JLabel("IDX");
		lblNewLabel.setFont(new Font("Consolas", Font.BOLD, 15));
		lblNewLabel.setBounds(12, 27, 67, 24);
		getContentPane().add(lblNewLabel);
		
		JLabel lblName = new JLabel("NAME");
		lblName.setFont(new Font("Consolas", Font.BOLD, 15));
		lblName.setBounds(12, 61, 67, 24);
		getContentPane().add(lblName);
		
		JLabel lblGender = new JLabel("GENDER");
		lblGender.setFont(new Font("Consolas", Font.BOLD, 15));
		lblGender.setBounds(12, 95, 67, 24);
		getContentPane().add(lblGender);
		
		JLabel lblRemark = new JLabel("REMARK");
		lblRemark.setFont(new Font("Consolas", Font.BOLD, 15));
		lblRemark.setBounds(12, 129, 67, 24);
		getContentPane().add(lblRemark);
		
		tf_idx = new JTextField();
		tf_idx.setFont(new Font("Consolas", Font.BOLD, 14));
		tf_idx.setBounds(91, 28, 124, 23);
		getContentPane().add(tf_idx);
		tf_idx.setColumns(10);
		
		tf_name = new JTextField();
		tf_name.setFont(new Font("Consolas", Font.BOLD, 14));
		tf_name.setColumns(10);
		tf_name.setBounds(91, 62, 124, 23);
		getContentPane().add(tf_name);
		
		tf_gender = new JTextField();
		tf_gender.setFont(new Font("Consolas", Font.BOLD, 14));
		tf_gender.setColumns(10);
		tf_gender.setBounds(91, 96, 124, 23);
		getContentPane().add(tf_gender);
		
		tf_remark = new JTextField();
		tf_remark.setFont(new Font("Consolas", Font.BOLD, 14));
		tf_remark.setColumns(10);
		tf_remark.setBounds(91, 130, 124, 23);
		getContentPane().add(tf_remark);
		
		btn1.setBounds(238, 125, 100, 30);
//		btn1.addActionListener(new ActionListener() {
//			@Override
//			public void actionPerformed(ActionEvent e) {
//				System.out.println("�̰Ŵ� �������̽�");
//			}
//		});
//		
//		btn1.addActionListener((e)->{ System.out.println("���..."); } );
		btn1.addActionListener(dbm);
		
		super.add(btn1);
		
		setSize(500,600);
		setVisible(true);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
//		for(int i=0; i< 10; i++)
//		{
//			JFrame jf = new JFrame(i+"");
//			jf.setSize(500,600);
//			jf.setVisible(true);
//		}
	}
	
	public static void main(String[] args) {
		new Ex01();
	}
}
