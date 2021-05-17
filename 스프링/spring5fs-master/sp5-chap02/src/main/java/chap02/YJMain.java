package chap02;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

public class YJMain {
	public static void main(String[] args) {
		//spring ...framework
		//jsp + 스프링객체 컨테이너를 활용해서 객채생성해서 
		//웹프로그래밍 하는 것....
		
		AnnotationConfigApplicationContext acac = new AnnotationConfigApplicationContext(YJContext.class);
		
		
		AA aa1 = acac.getBean("aa",AA.class);
		System.out.println(aa1);
		aa1.doA();
		System.out.println(aa1.print("doAdoAdoA"));
		
		AA aa2 =acac.getBean("aa",AA.class);
		System.out.println(aa2);
		
		AA aa3 = new AA();
		System.out.println(aa3);
		aa3.doA();
		System.out.println(aa3.print("직접생성함"));
		
		BB bb1= acac.getBean("bb",BB.class);
		System.out.println(bb1);
		
		BB bb2= acac.getBean("bb",BB.class);
		System.out.println(bb2);
		
		BB bb3 = new BB();
		System.out.println(bb3);
		
		CC cc1 = CC.getInstance();
		System.out.println(cc1);
		
		CC cc2 = CC.getInstance();
		System.out.println(cc2);
		
		CC cc3= new CC();
		System.out.println(cc3);
		
		
	}

}
