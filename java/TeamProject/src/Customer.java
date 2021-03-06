
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
		 String data = ">>>>>>>>>>>>> ???? ???? <<<<<<<<<<";
         data += "???? Id: " + custId + "\n";
         data += "???? ?̸?: " + custName + "\n";
         data += "????(YYYY): " + custAge + "\n";
         data += "????: " + custGender + "\n";
         data += "?ּ?: " + custAddress + "\n";
         data += "??ȭ??ȣ: " + custPhone + "\n";
         data += "---------------------------------";
         return data;
	}
	public void custPrintINfo()
	{
		System.out.println(">>>>>>>>>>>>> ???? ???? <<<<<<<<<<");
		System.out.println("???? Id: " + custId);
		System.out.println("???? ?̸?: " + custName);
		System.out.println("????(YYYY): " + custAge);
		System.out.println("????: " + custGender);
		System.out.println("?ּ?: " + custAddress);
		System.out.println("??ȭ??ȣ: " + custPhone);
		System.out.println("---------------------------------");
		
	}
	
}
