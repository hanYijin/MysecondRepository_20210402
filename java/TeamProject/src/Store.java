
public class Store {
	private String stoName;
	private String manager;
	private String phone;
	private String address;
	
	public Store(String name, String manager, String phone, String address){
		this.stoName=name;
		this.manager=manager;
		this.phone=phone;
		this.address=address;
	}
	public String getStoName() {
		return stoName;
	}
	public void setStoName(String stoName) {
		this.stoName = stoName;
	}
	public String getManager() {
		return manager;
	}
	public void setManager(String manager) {
		this.manager = manager;
	}
	public String getPhone() {
		return phone;
	}
	public void setPhone(String phone) {
		this.phone = phone;
	}
	public String getAddress() {
		return address;
	}
	public void setAddress(String address) {
		this.address = address;
	}
	@Override
	public String toString() {
		String data = ">>>>>>>>>>>>> 약국 정보 <<<<<<<<<<";
        data += "약국명: " +stoName + "\n";
        data += "매니저: " + manager + "\n";
        data += "전화번호: " + phone + "\n";
        data += "주소: " + address + "\n";
        data += "---------------------------------";
        return data;
	}
	public void stoPrintInfo(){
		System.out.println(">>>>>>>>>>>>> 약국 정보 <<<<<<<<<<");
		System.out.println("약국명: " + stoName);
		System.out.println("매지저: " +manager);
		System.out.println("전화번호: " +phone);
		System.out.println("주소: " +address);
		System.out.println("---------------------------------");
	}
	

}
