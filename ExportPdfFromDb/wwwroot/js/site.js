$(document).ready(function () {
    $("#PrintPDF").click(function () {
        var element = document.getElementById("ParentDiv")
        html2pdf().from(element).set().save();
    });

    //$("#btn-print").click(function () {
    //    $("#ParentDiv").printThis();
         
    //});
})

document.getElementById("btn-print").onclick = function () {
    debugger;
    // Select Area
    var area_id = document.getElementById("ParentDiv").innerHTML;
    // Select body 
    var body = document.body.innerHTML;
    document.body.innerHTML = area_id;
    window.print();
    document.body.innerHTML = body;
}
    

