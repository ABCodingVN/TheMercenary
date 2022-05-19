import React from 'react';
import { Box,Grid } from '@material-ui/core';
import Product from './Product';

function ProductList({data}) {
    
    return (
        <Box sx={{display:'flex', flexWrap:'wrap',justifyContent:'center'}} >
            {data.products.map((product)=>(
                <Grid item key={product.ProductId} >
                    <Product product={product} />
                </Grid>
            ))}                  
        </Box>
                
       
    );
}

export default ProductList;