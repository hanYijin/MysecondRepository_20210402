// ctrl+ shift + f �ڵ�����
public class Person extends Object{
	String name;
	Person(String name) {
		this.name = name;
	}
	// alt + shift + s
	@Override
	protected void finalize() throws Throwable {
		super.finalize();
		System.out.println("�������� ���������� �޸𸮻󿡼� ����");
		System.out.println("name = "+name);
	}
}
