import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;

public class MyListen implements ActionListener{

	@Override
	public void actionPerformed(ActionEvent e) {
		JButton btn = (JButton)e.getSource();
		String seat = btn.getText();
		if(seat.contains("1��")) {
			System.out.println("1��Ŭ��");
			btn.setBackground(Color.gray);
		}
		if(seat.contains("2��")) {
			System.out.println("2��Ŭ��");
			btn.setBackground(Color.GREEN);
		}
		if(seat.contains("3��")) {
			System.out.println("3��Ŭ��");
			btn.setBackground(Color.YELLOW);
		}
		
	}

}
