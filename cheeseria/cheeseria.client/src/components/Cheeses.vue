<script setup>
import CheeseCard from "./CheeseCard.vue";
const props = defineProps(['cheeseArray'])

</script>

<template>
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <div v-for="cheese in props.cheeseArray" :key="cheese.name" class="col card-col">
            <CheeseCard>
                <template #picture>
                    <img class="card-image" :src="cheese.imageUrl" alt="Cheese image" />
                </template>
                <template #name>
                    <span>{{cheese.name}}</span>
                </template>
                <template #colour>
                    <span>{{cheese.colour}}</span>
                </template>
                <template #pricePerKilo>
                    <span>{{cheese.pricePerKilo}}</span>
                </template>
            </CheeseCard>
        </div>
    </div>
</template>

<style scoped>
.card-image{
  border-radius: 12px 12px 0px 0px;
    width:  100%;
    min-height: 245px;
    object-fit: cover;
}
.card-col{
    display: flex;
    justify-content: center;
}
</style>