<template>
    <div class="card item" style="width: 18rem;">
        <slot  name="picture"></slot>
        <div class="card-body">
            <h5 class="card-title"><slot name="name"></slot></h5>
            <p class="card-text">Colour: <slot name="colour"></slot></p>
            <p class="card-text">Price Per Kilo:  <slot name="pricePerKilo"></slot></p>
        </div>
    </div>
</template>

<style scoped>

.item {
  margin: 2rem;
  border-radius: 12px;
  background-color: var(--color-body-background);
  box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
}

</style>
