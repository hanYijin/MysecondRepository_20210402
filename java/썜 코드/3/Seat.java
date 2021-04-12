
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.*;


public class Seat{
	static int k = 0;
	static int[] seat = { 0, };
	static int seatnum;
	public static Action ml = new Action();
	public static void main(String[] args) {
		
		JFrame jf = new JFrame("좌석 배치표");
		
		jf.setTitle("좌석 배치표");
		jf.setSize(600, 600);
		jf.setLocationRelativeTo(null);
		jf.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		jf.setLayout(null);
		
		JButton btn1 = new JButton("1");
		btn1.setBounds(12, 22, 80, 44);
		btn1.addActionListener(ml);
		jf.add(btn1);
		
		JButton btn2 = new JButton("2");
		btn2.addActionListener(ml);
		btn2.setBounds(115, 22, 80, 44);
		jf.add(btn2);
				
		JButton btn3 = new JButton("3");
		btn3.addActionListener(ml);
		btn3.setBounds(216, 22, 80, 44);
		jf.add(btn3);

		JButton btn4 = new JButton("4");
		btn4.addActionListener(ml);
		btn4.setBounds(316, 22, 80, 44);
		jf.add(btn4);

		JButton btn5 = new JButton("5");
		btn5.setBounds(408, 22, 80, 44);
		jf.add(btn5);
		btn5.addActionListener(ml);
		
		JButton btn6 = new JButton("6");
		btn6.setBounds(500, 22, 80, 44);
		jf.add(btn6);
		btn6.addActionListener(ml);
		
		JButton btn7 = new JButton("7");
		btn7.setBounds(12, 76, 80, 44);
		jf.add(btn7);
		btn7.addActionListener(ml);
		
		JButton btn8 = new JButton("8");
		btn8.setBounds(149, 103, 80, 44);
		jf.add(btn8);
		btn8.addActionListener(ml);

		JButton btn9 = new JButton("9");
		btn9.setBounds(241, 103, 80, 44);
		jf.add(btn9);
		btn9.addActionListener(ml);
		
		JButton btn10 = new JButton("10");
		btn10.setBounds(333, 103, 80, 44);
		jf.add(btn10);
		btn10.addActionListener(ml);
		
		JButton btn11 = new JButton("11");
		btn11.setBounds(500, 76, 80, 44);
		jf.add(btn11);
		btn11.addActionListener(ml);
		
		JButton btn12 = new JButton("12");
		btn12.setBounds(12, 135, 80, 44);
		jf.add(btn12);
		btn12.addActionListener(ml);
		
		JButton btn13 = new JButton("13");
		btn13.setBounds(500, 130, 80, 44);
		jf.add(btn13);
		btn13.addActionListener(ml);
		
		JButton btn14 = new JButton("14");
		btn14.setBounds(12, 189, 80, 44);
		jf.add(btn14);
		btn14.addActionListener(ml);

		JButton btn15 = new JButton("15");
		btn15.setBounds(149, 157, 80, 44);
		jf.add(btn15);
		btn15.addActionListener(ml);
		
		JButton btn16 = new JButton("16");
		btn16.setBounds(241, 157, 80, 44);
		jf.add(btn16);
		btn16.addActionListener(ml);

		JButton btn17 = new JButton("17");
		btn17.setBounds(333, 157, 80, 44);
		jf.add(btn17);
		btn17.addActionListener(ml);

		JButton btn18 = new JButton("18");
		btn18.setBounds(500, 184, 80, 44);
		jf.add(btn18);
		btn18.addActionListener(ml);
		
		JButton btn19 = new JButton("19");
		btn19.setBounds(12, 243, 80, 44);
		jf.add(btn19);
		btn19.addActionListener(ml);
		
		JButton btn20 = new JButton("20");
		btn20.setBounds(500, 238, 80, 44);
		jf.add(btn20);
		btn20.addActionListener(ml);
		
		JButton btnOK = new JButton("확인");
		btnOK.setBounds(483, 462, 97, 35);
		jf.add(btnOK);
		btnOK.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				seatnum = 7;
			}
		});		

		JButton btnBack = new JButton("취소");
		btnBack.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				jf.dispose();
			}
		});
		btnBack.setBounds(483, 417, 97, 35);
		jf.add(btnBack);	

		jf.setVisible(true);
	}
}
