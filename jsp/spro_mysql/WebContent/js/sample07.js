// 막대 그래프 데이터(데이터셋)
function doGra(dataSet){
	d3.select("#myGraph")				    // SVG 요소 지정
		.selectAll("rect")					// SVG로 사각형을 표시할 요소를 지정
		.data(dataSet)						// 데이터 설정
		.enter()							// 데이터 수에 따라 rect 요소 생성
		.append("rect")						// SVG 사각형 생성
		.attr("x", 0)							// 가로형 막대그래프이므로 X좌표를 0으로 함
		.attr("y", function(d,i){			// Y 좌표를 배열의 순서에 따라 계산
			return i * 25;					// 막대그래프의 높이를 25px 단위로 계산
		})
    	.attr("height", "20px")			    // 막대그래프의 높이를 20px로 지정
    	.attr("width", "0px")
    	.transition()
    	.delay(function(d,i){
    		return i*500;
    	})
    	.duration(function(d,i){
    		return 2500;
    	})
    	.attr("width", function(d,i){
    		return d+"px";
    	})
    var xScale = d3.scale.linear()  // 선형 스케일 설정
   		.domain([0, 300])   // 원래 데이터 범위
   		.range([0, 300])  // 실제 출력 크기
// 눈금을 설정하고 표시
   	d3.select("#myGraph")
   		.append("g")	// 그룹화함
   		.attr("class", "axis")	// 스타일시트 클래스 설정
   		.attr("transform", "translate(10, "+((1+dataSet.length) * 20+5)+")")	// 표시 위치 조정
   		.call(d3.svg.axis()	// call()로 눈금을 표시할 함수를 호출
   		.scale(xScale)  // 스케일을 적용
   		.orient("bottom")   // 눈금의 표시 위치를 아래쪽으로 지정
   		)
};

