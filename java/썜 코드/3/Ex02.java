import java.awt.Color;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;

public class Ex02 {
	static int cheked = 0;
	public static MyListen ml = new MyListen();
	public static void main(String[] args) {
		
		JFrame frame = new JFrame("GridLayout Test");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setLayout(new GridLayout(3, 2));
		
		JButton btn1 =  new JButton("1¹øÁÂ¼®");
		btn1.addActionListener(ml);
		JButton btn2 =  new JButton("2¹øÁÂ¼®");
		btn2.addActionListener(ml);
		JButton btn3 =  new JButton("3¹øÁÂ¼®");
		btn3.addActionListener(ml);
		
		frame.add(btn1);
		frame.add(btn2);
		frame.add(btn3);
		frame.add(new JButton("Button 4"));
		frame.add(new JButton("Button 5"));
		frame.add(new JButton("Button 6"));
		frame.add(new JButton("Button 7"));
		frame.add(new JButton("Button 8"));
		frame.pack();
		frame.setVisible(true);
	}
}
