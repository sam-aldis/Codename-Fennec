function when_ready() {
    console.log("loaded");
    $(".markdown").load("README.md", "data", function (response, status, request) {
        console.log(response);
        var converter = new showdown.Converter();
        this.innerHTML = converter.makeHtml(response); // dom element
        
    });("/README.md");
};