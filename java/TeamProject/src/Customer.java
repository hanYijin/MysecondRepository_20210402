
public class Customer {
	private String custId;
	private String custName;
	private int custAge;
	private char custGender;
	private String custAddress;
	private String custPhone;
	
	public Customer(String custId, String custName, int custAge, char custGender, String custAddress, String custPhone){
		this.custId=custId;
		this.custName=custName;
		this.custAge=custAge;
		this.custGender=custGender;
		this.custAddress=custAddress;
		this.custPhone=custPhone;
	}
	//alt + shift+ S -> R

	public String getCustId() {
		return custId;
	}

	public void setCustId(String custId) {
		this.custId = custId;
	}

	public String getCustName() {
		return custName;
	}

	public void setCustName(String custName) {
		this.custName = custName;
	}

	public int getCustAge() {
		return custAge;
	}

	public void setCustAge(int custAge) {
		this.custAge = custAge;
	}

	public char getCustGender() {
		return custGender;
	}

	public void setCustGender(char custGender) {
		this.custGender = custGender;
	}

	public String getCustAddress() {
		return custAddress;
	}

	public void setCustAddress(String custAddress) {
		this.custAddress = custAddress;
	}

	public String getCustPhone() {
		return custPhone;
	}

	public void setCustPhone(String custPhone) {
		this.custPhone = custPhone;
	}

	@Override
	public String toString() {
		 String data = ">>>>>>>>>>>>> 고객 정보 <<<<<<<<<<";
         data += "고객 Id: " + custId + "\n";
         data += "고객 이름: " + custName + "\n";
         data += "생년(YYYY): " + custAge + "\n";
         data += "성별: " + custGender + "\n";
         data += "주소: " + custAddress + "\n";
         data += "전화번호: " + custPhone + "\n";
         data += "---------------------------------";
         return data;
	}
	public void custPrintINfo()
	{
		System.out.println(">>>>>>>>>>>>> 고객 정보 <<<<<<<<<<");
		System.out.println("고객 Id: " + custId);
		System.out.println("고객 이름: " + custName);
		System.out.println("생년(YYYY): " + custAge);
		System.out.println("성별: " + custGender);
		System.out.println("주소: " + custAddress);
		System.out.println("전화번호: " + custPhone);
		System.out.println("---------------------------------");
		
	}
	
}
