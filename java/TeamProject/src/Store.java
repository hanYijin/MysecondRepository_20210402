
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
		String data = ">>>>>>>>>>>>> �౹ ���� <<<<<<<<<<";
        data += "�౹��: " +stoName + "\n";
        data += "�Ŵ���: " + manager + "\n";
        data += "��ȭ��ȣ: " + phone + "\n";
        data += "�ּ�: " + address + "\n";
        data += "---------------------------------";
        return data;
	}
	public void stoPrintInfo(){
		System.out.println(">>>>>>>>>>>>> �౹ ���� <<<<<<<<<<");
		System.out.println("�౹��: " + stoName);
		System.out.println("������: " +manager);
		System.out.println("��ȭ��ȣ: " +phone);
		System.out.println("�ּ�: " +address);
		System.out.println("---------------------------------");
	}
	

}
