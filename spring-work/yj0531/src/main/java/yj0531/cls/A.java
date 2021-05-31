package yj0531.cls;

import org.springframework.beans.factory.DisposableBean;
import org.springframework.beans.factory.InitializingBean;

public class A  implements InitializingBean, DisposableBean {
	public void doA() {
		System.out.println("doA");
	}
	public void afterPropertiesSet() throws Exception{
		System.out.println("A클래스 생성하고 나서 실행");
	}
	public void destroy() throws Exception{
		System.out.println("스프링 객체 담는 통 없을때...");
	}

}
