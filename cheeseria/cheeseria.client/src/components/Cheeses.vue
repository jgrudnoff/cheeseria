<script setup>
import CheeseCard from "./CheeseCard.vue";
import { ref, onMounted } from 'vue'
import productService from "../services/product.service"
const ProductService = new productService();
//import imageUrl from '@/assets/gouda.jpg'

const props = defineProps(['cheeseArray'])

</script>

<template>
<div class="row row-cols-1 row-cols-md-3 g-4">
  <div v-for="cheese in props.cheeseArray" :key="cheese.name" class="col">
      <CheeseCard  >
          <template #picture>
              <img :src="cheese.imageUrl" alt="Cheese image" />
          </template>
          <template #name>
              {{cheese.name}}
          </template>
          <template #colour>
              {{cheese.colour}}
          </template>
          <template #pricePerKilo>
              {{cheese.pricePerKilo}}
          </template>
      </CheeseCard>
  </div>


</div>
      
      <!-- <CheeseCard v-for="cheese in cheeseArray" :key="cheese.name">
          <template #picture>
              <img :src="cheese.imageUrl" alt="Cheese image" />
          </template>
          <template #name>
              {{cheese.name}}
          </template>
          <template #colour>
              {{cheese.colour}}
          </template>
          <template #pricePerKG>
              {{cheese.pricePerKG}}
          </template>
      </CheeseCard> -->

</template>

<style scoped>

</style>