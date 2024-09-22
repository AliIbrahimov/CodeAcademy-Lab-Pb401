const form = document.querySelector("#text-form");
const textInput = document.querySelector("#text-input");
const textList = document.querySelector(".list-group");
const firstCardBody = document.querySelectorAll(".card-body")[0];
const secondCardBody = document.querySelectorAll(".card-body")[1];
const clearButton = document.querySelector("#clear-texts");

eventListeners();

function eventListeners()
{
    form.addEventListener("submit", addText);
    secondCardBody.addEventListener("click", deleteText);
    clearButton.addEventListener("click", clearAllTexts);
}

function addText(e)
{
    const newText = textInput.value.trim();
    if (newText === "")
    {
        showAlert("danger", "Not empty value!!!");
    }
    else
    {
        addTextToUi(newText);
        showAlert("success", `'${newText}' elave edildi!`)
    }
    textInput.value = "";

}

function addTextToUi(newText)
{
    const listItem = document.createElement("li");
    const link = document.createElement("a");
    link.href = "#";
    link.className = "delete-item";
    link.innerHTML = "<i class='fa-solid fa-trash'></i>";
    listItem.className = "list-group-item d-flex justify-content-between";
    listItem.appendChild(document.createTextNode(newText));
    listItem.appendChild(link);
    textList.appendChild(listItem);
}

function showAlert(type, message)
{
    const alert = document.createElement("div");
    alert.className = `alert alert-${type}`
    alert.textContent = message;
    firstCardBody.appendChild(alert)
    setTimeout(() =>
    {
        alert.remove();
    }, 2000);
}

function clearAllTexts()
{
    if (confirm("Hamisin silmek isteyirsiz?") && textList.innerHTML != "")
    {
        textList.innerHTML = "";
        showAlert("info", "All texts are deleted!");
    }
}
