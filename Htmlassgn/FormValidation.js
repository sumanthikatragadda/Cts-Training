function validateForm() {
    var x = document.forms["myForm"]["Name"].value;
    if (x == "[0-9]")
        alert("should not contain numbers");
    

}
validateForm();