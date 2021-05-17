package chap02;

public class AA {
	private String fom="%s";
	public void doA() {
		System.out.println("doA");
	}
	public String print(String str) {
		return String.format(fom, str );
	}

}
