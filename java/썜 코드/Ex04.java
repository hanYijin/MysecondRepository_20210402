class MyException extends Exception{
	MyException(){
		super("���� ���� ���ܻ�Ȳ");
	}
}

public class Ex04 {
	Ex04(){
		try {
			throw new MyException();
		}catch (Exception me) {
			System.out.println(me.getMessage());
		}
	}

	public static void main(String[] args) {
		new Ex04();
	}
}
