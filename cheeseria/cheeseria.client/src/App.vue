<script setup>
    import Cheeses from "./components/Cheeses.vue";
    import PriceCalculator from "./components/PriceCalculator.vue";
    import productService from "./services/product.service"
    const ProductService = new productService();
    import { ref, onMounted } from 'vue'

    let cheeseArray = ref([])

    onMounted(async () => {
      try {
        let response = await ProductService.GetCheese()
        for (let i = 0; i < response.length; i++) {
          response[i].imageUrl = `/img/${response[i].name}.jpg`
          console.log(response[i].imageUrl)
        }
        cheeseArray.value = response;
      } catch(ex) {
        console.error("Error after loading cheese", ex)
      }
    })
</script>

<template>
  <div>
    <Cheeses :cheese-array="cheeseArray"/>
    <PriceCalculator :cheese-array="cheeseArray"/>
  </div>
</template>

<style scoped>

</style>
