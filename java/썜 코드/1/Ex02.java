
public class Ex02 {

	public static void main(String[] args) {
		INum i1 = new INum(10,"��翬");
		INum i2 = new INum(12,"��Ǹ�");
		INum i3 = new INum(10,"������");
		
		if(i1.equals(i2))
			System.out.println("i1 == i2 ������ �ٸ���");
		
		if(i1.equals(i3))
			System.out.println("i1 == i3 ������ �Ȱ���");
		
		if(i1 == i2)
			System.out.println("i1 == i2 �Ȱ���");
		
		if(i1 == i3)
			System.out.println("i1 == i3 �Ȱ���");
	}
}
