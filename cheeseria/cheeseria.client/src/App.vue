<script setup>
    import Cheeses from "./components/Cheeses.vue";
    import PriceCalculator from "./components/PriceCalculator.vue";
    import { GetCheese } from "./services/product.service"
    import { ref, onMounted } from 'vue'

    let cheeseArray = ref([])

    function checkIfImageExists(url, callback) {
      const img = new Image();
      img.src = url;

      if (img.complete) {
        callback(true);
      } else {
        img.onload = () => {
          callback(true);
        };
        
        img.onerror = () => {
          callback(false);
        };
      }
    }
    

    onMounted(async () => {
      try {
        let response = await GetCheese()
        cheeseArray.value = response;
        for (let i = 0; i < response.length; i++) {
          let imageUrl = `/img/${response[i].name.toLowerCase()}.jpg`

          //response[i].imageUrl = `/img/${response[i].name}.jpg`
          checkIfImageExists(imageUrl, (exists) => {
            if (exists) {
              console.log("exists")
              cheeseArray.value[i].imageUrl = `/img/${response[i].name.toLowerCase()}.jpg`
            } else {
              cheeseArray.value[i].imageUrl = `/img/placeholder-cheese.svg`
            }
          });    
        }
      } catch(ex) {
        console.error("Error after loading cheese", ex)
      }
    })
</script>

<template>
  <div class="app-container">
    <div class="main-title-container">
      <span class="main-title">Welcome to the Cheeseria!</span>

    </div>
    <Cheeses :cheese-array="cheeseArray"/>
    <PriceCalculator :cheese-array="cheeseArray"/>
  </div>
</template>

<style scoped>

.main-title-container{
  text-align: center;
  font-size: 60px;
  padding: 1rem 4rem;
  border-radius: 12px;;
}

.main-title{

}
.app-container{
  display: flex;
  flex-direction: column;
  align-items: center;
}

</style>
