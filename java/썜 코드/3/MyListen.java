import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;

public class MyListen implements ActionListener{

	@Override
	public void actionPerformed(ActionEvent e) {
		JButton btn = (JButton)e.getSource();
		String seat = btn.getText();
		if(seat.contains("1번")) {
			System.out.println("1번클릭");
			btn.setBackground(Color.gray);
		}
		if(seat.contains("2번")) {
			System.out.println("2번클릭");
			btn.setBackground(Color.GREEN);
		}
		if(seat.contains("3번")) {
			System.out.println("3번클릭");
			btn.setBackground(Color.YELLOW);
		}
		
	}

}
