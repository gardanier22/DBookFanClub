$("#btnsubmit").click(function () {
    alert("From" + $("#txtFrom").val() +
        ", Subject=" + $("#txtSubject").val() +
        ", Message=" + $("#txtMessage").val());

    $("#imgBook").fadeOut("slow");
})