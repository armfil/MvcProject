const mobileMenuButton = document.querySelector("#mobile-menu-btn");
const mobileMenu = document.querySelector("#mobile-menu");
const userMenuButton = document.querySelector("#user-menu-btn");
const userMenu = document.querySelector("#user-menu");

mobileMenuButton.addEventListener("click", () => {
    if (mobileMenu.classList.contains("hidden")){
        mobileMenu.classList.remove("hidden");
    }
    else{
        
        mobileMenu.classList.add("hidden");
    }
})

userMenuButton.addEventListener("click", () => {
    if (userMenu.classList.contains("hidden")){
        userMenu.classList.remove("hidden");
    }
    else{
        userMenu.classList.add("hidden");
    }
})
