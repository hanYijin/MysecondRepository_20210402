import java.awt.BorderLayout;
import java.util.Vector;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;

public class Ex01 extends JFrame{
	private JTable table;
	public Ex01() {
		
		JPanel panel = new JPanel();
		getContentPane().add(panel, BorderLayout.CENTER);
		
		Vector title = new Vector();
		Vector data = new Vector<Vector>();
		
		title.add("Ÿ��Ʋ");
		title.add("Ÿ��Ʋ");
		title.add("Ÿ��Ʋ");
		
		Vector da1 = new Vector<>();
		da1.add("����");
		da1.add("����");
		da1.add("����");
		
		data.add(da1);
		data.add(da1);
		data.add(da1);
		
		table = new JTable(data,title);
		JScrollPane sp = new JScrollPane(table);

		panel.add(sp);
		setSize(300,500);
		setVisible(true);
	}

	public static void main(String[] args) {
		new Ex01();
	}
}
