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


/* 
.details {
  flex: 1;
  margin-left: 1rem;
}

i {
  display: flex;
  place-items: center;
  place-content: center;
  width: 32px;
  height: 32px;

  color: var(--color-text);
}

h3 {
  font-size: 1.2rem;
  font-weight: 500;
  margin-bottom: 0.4rem;
  color: var(--color-heading);
}

@media (min-width: 1024px) {
  .item {
    margin-top: 0;
    padding: 0.4rem 0 1rem calc(var(--section-gap) / 2);
  }

  i {
    top: calc(50% - 25px);
    left: -26px;
    position: absolute;
    border: 1px solid var(--color-border);
    background: var(--color-background);
    border-radius: 8px;
    width: 50px;
    height: 50px;
  }

  .item:before {
    content: " ";
    border-left: 1px solid var(--color-border);
    position: absolute;
    left: 0;
    bottom: calc(50% + 25px);
    height: calc(50% - 25px);
  }

  .item:after {
    content: " ";
    border-left: 1px solid var(--color-border);
    position: absolute;
    left: 0;
    top: calc(50% + 25px);
    height: calc(50% - 25px);
  }

  .item:first-of-type:before {
    display: none;
  }

  .item:last-of-type:after {
    display: none;
  }
}*/ 
</style>
