
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
		 String data = ">>>>>>>>>>>>> 약품 정보 <<<<<<<<<<"+"\n";
         data += "제품 코드: " + pId + "\n";
         data += "약품명: " + mediName + "\n";
         data += "효과(증상): " + effect + "\n";
         data += "복용법: " + taking + "\n";
         data += "가격: " + price + "\n";
         data += "---------------------------------";
         return data;
	}
	public void mediPrintInfo()
	{
		System.out.println(">>>>>>>>>>>>> 약품 정보 <<<<<<<<<<");
		System.out.println("PID: " + pId);
		System.out.println("Product: " + mediName);
		System.out.println("Effect: " + effect);
		System.out.println("Taking: " + taking);
		System.out.println("Price: " + price);
		System.out.println("----------------------------------");
	}
	
	

}
