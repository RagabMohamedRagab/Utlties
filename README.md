<img src="Help/HtmlToPdf.jpg" style="height:350px;width:100%">
<hr/>

# Client-side HTML-to-PDF rendering using pure JS.

## 1- CDN
> The simplest way to use html2pdf.js is to include it as a script in your HTML by using cdnjs:

```bash
<script src="https://cdnjs.cloudflare.com/ajax/libs/html2pdf.js/0.10.1/html2pdf.bundle.min.js"></script>
```

## 2- Usage

>Once installed, html2pdf.js is ready to use. The following command will generate a PDF of #element-to-print and prompt the user to save the result:

```bash
 $("#PrintPDF").click(function () {
        var element = document.getElementById("ParentDiv")
        html2pdf().from(element).set().save();
    });
```
## 3-Test
<img src="Help/Capture.PNG" style="height:250px;width:100%">
<br/>
<img src="Help/Download.PNG" style="height:250px;width:100%">
