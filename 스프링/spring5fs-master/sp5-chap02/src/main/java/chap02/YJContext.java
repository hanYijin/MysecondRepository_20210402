package chap02;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

// 싱글톤 담은 통 객체
@Configuration
public class YJContext {
	@Bean
	public AA aa() {
		AA aa = new AA();
		return aa;
	}
	@Bean
	public BB bb() {
		BB bb = new BB();
		return bb;
	}

}
