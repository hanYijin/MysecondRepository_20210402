
public class Medicine {
	private String pId;
	private String mediName;
	private String effect;
	private String taking;
	private String price;
	
	public Medicine(String id, String name, String effect, String taking, String price){
		this.pId=id;
		this.mediName=name;
		this.effect=effect;
		this.taking=taking;
		this.price=price;
	}
	public String getpId() {
		return pId;
	}
	public void setpId(String pId) {
		this.pId = pId;
	}
	public String getMediName() {
		return mediName;
	}
	public void setMediName(String mediName) {
		this.mediName = mediName;
	}
	public String getEffect() {
		return effect;
	}
	public void setEffect(String effect) {
		this.effect = effect;
	}
	public String getTaking() {
		return taking;
	}
	public void setTaking(String taking) {
		this.taking = taking;
	}
	public String getPrice() {
		return price;
	}
	public void setPrice(String price) {
		this.price = price;
	}
	@Override
	public String toString() {
		 String data = ">>>>>>>>>>>>> ��ǰ ���� <<<<<<<<<<"+"\n";
         data += "��ǰ �ڵ�: " + pId + "\n";
         data += "��ǰ��: " + mediName + "\n";
         data += "ȿ��(����): " + effect + "\n";
         data += "�����: " + taking + "\n";
         data += "����: " + price + "\n";
         data += "---------------------------------";
         return data;
	}
	public void mediPrintInfo()
	{
		System.out.println(">>>>>>>>>>>>> ��ǰ ���� <<<<<<<<<<");
		System.out.println("PID: " + pId);
		System.out.println("Product: " + mediName);
		System.out.println("Effect: " + effect);
		System.out.println("Taking: " + taking);
		System.out.println("Price: " + price);
		System.out.println("----------------------------------");
	}
	
	

}
