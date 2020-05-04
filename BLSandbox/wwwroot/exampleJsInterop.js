window.exampleJsFunctions = {
    showPrompt: function (text) {
        return prompt(text, 'Type your name here');
    },
    displayWelcome: function (welcomeMessage) {
        document.getElementById('welcome').innerText = welcomeMessage;
    },

    returnANurseryRhymeFromDotNet: function () {
        DotNet.invokeMethodAsync('BLSandbox', 'ReturnANurseryRhyme')
            .then(data => {

                data.push("I Smell the blood of an Englishman!");

                var element = document.getElementById('nurseryrhyme');
                for (var i = 0; i < data.length; i++) {
                    var child = document.createElement("LI");
                    child.innerHTML = data[i];
                    element.appendChild(child)
                }
            });
    },

    sayHello: function (dotnetHelper) {
        return dotnetHelper.invokeMethodAsync('SayHello')
            .then(r => console.log(r));
    }
};