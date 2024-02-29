// Function to open login popup
function openLoginPopup() {
    document.getElementById("login-popup").classList.add("active");
}

// Function to close login popup
function closeLoginPopup() {
    document.getElementById("login-popup").classList.remove("active");
}

// Event listener for login button
document.getElementById("login-btn").addEventListener("click", function () {
    openLoginPopup();
});

// Event listener for close button within the popup
document.getElementById("close-login-btn").addEventListener("click", function () {
    closeLoginPopup();
});
