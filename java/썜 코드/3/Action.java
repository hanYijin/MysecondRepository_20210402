
import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JOptionPane;

public class Action implements ActionListener {

	static int k = 0;

	@Override
	public void actionPerformed(ActionEvent e) {
		JButton btn = (JButton) e.getSource();
		String seatnum = btn.getText();

		btn.setBackground(Color.cyan);
		int num = Integer.parseInt(seatnum);
		k++;
		if (k > 1) {
			JOptionPane.showMessageDialog(null, "더 이상 선택할 수 없습니다.");

		}
	}
}
