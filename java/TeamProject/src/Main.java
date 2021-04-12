import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;

public class Main extends JFrame {
	JButton cust_but = new JButton("고객용");
	JButton phar_but = new JButton("약국용");
	
	public Main(){
		getContentPane().setLayout(null);
		cust_but.setBounds(41, 50, 130, 53);
		getContentPane().add(cust_but);
		
		phar_but.setBounds(247, 50, 130, 53);
		getContentPane().add(phar_but);
		
		setSize(430,200);
		setLocationRelativeTo(null);
		setVisible(true);
		
		cust_but.addActionListener(new ActionListener(){
			@Override
			public void actionPerformed(ActionEvent e1){
				Customer c_fram= new Customer();
			}
		});
		phar_but.addActionListener(new ActionListener(){
			@Override
			public void actionPerformed(ActionEvent e1){
				Pharmacy p_fram= new Pharmacy();
			}
		});
		
	}
	public static void main(String[] args) {
		new Main();
		
		
	} 

}
