$(document).ready(() => {
  getGames();
  getGamesByPrice(7);
  getGamesByPrice(5);
  getGamesByRank(9);
});

const Btn = document.getElementById("myBtn");
Btn.addEventListener("click", getGames);

function getGames() {
  ajaxCall(
    "GET",
    "https://localhost:7031/api/Games",
    "",
    getGamesSCB,
    getGamesECB
  );
}

function getGamesSCB(obj) {
  console.log(obj);
  renderGames(obj);
}

function getGamesECB(obj) {
  console.log(obj);
}

function getGamesByPrice(price) {
  const url = `https://localhost:7031/api/Games/ReadGamesByPrice?minPrice=${price}`;

  ajaxCall("GET", url, "", getGamesByPriceSCB, getGamesByPriceECB);
}

function getGamesByPriceSCB(obj) {
  console.log(obj);
}

function getGamesByPriceECB(obj) {
  console.log(obj);
}

function getGamesByRank(rank) {
  const url = `https://localhost:7031/api/Games/ReadGamesByRank/${rank}`;

  ajaxCall("GET", url, "", "", "");
}

function renderGames(games) {
  games.forEach((game) => {
    let str = `<div class="game">App ID:${game.appId1} - Name: ${game.name1} 
    <div>
    <button id="btn${game.appId1}">click</button>
    </div>
    </div>`;
    document.getElementById("container").innerHTML += str;

    // const myDiv = document.createElement("div");
    // myDiv.classList.add("game");
    // myDiv.innerText = `App ID:${game.appId1} - Name: ${game.name1}`;
    // document
    //   .getElementById("container")
    //   .insertAdjacentElement("beforeend", myDiv);
  });
}
